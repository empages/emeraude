using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using EmPages.Common;
using EmPages.Identity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace EmPages.Identity.Services;

/// <inheritdoc />
internal class EmIdentityService : IEmIdentityService
{
    private readonly EmUserManager userManager;
    private readonly EmIdentityContext identityContext;
    private readonly IHttpContextAccessor httpContextAccessor;
    private readonly IEmIdentityOptions identityOptions;
    private readonly ILogger<EmIdentityService> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmIdentityService"/> class.
    /// </summary>
    /// <param name="userManager"></param>
    /// <param name="identityContext"></param>
    /// <param name="httpContextAccessor"></param>
    /// <param name="identityOptions"></param>
    /// <param name="logger"></param>
    public EmIdentityService(
        EmUserManager userManager,
        EmIdentityContext identityContext,
        IHttpContextAccessor httpContextAccessor,
        IEmIdentityOptions identityOptions,
        ILogger<EmIdentityService> logger)
    {
        this.userManager = userManager;
        this.identityContext = identityContext;
        this.httpContextAccessor = httpContextAccessor;
        this.identityOptions = identityOptions;
        this.logger = logger;
    }

    /// <inheritdoc/>
    public async Task<EmUserModel> FindUserAsync(Guid userId)
    {
        try
        {
            var identityUser = await this.userManager.FindByIdAsync(userId.ToString());
            if (identityUser == null)
            {
                return null;
            }

            return await this.MapUserAsync(identityUser);
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "Finding user failed");
            return null;
        }
    }

    /// <inheritdoc/>
    public async Task<EmUserModel> FindUserAsync(string email)
    {
        try
        {
            var identityUser = await this.userManager.FindByEmailAsync(email);
            if (identityUser == null)
            {
                return null;
            }

            return await this.MapUserAsync(identityUser);
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "Finding user failed");
            return null;
        }
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<EmUserModel>> FetchUsersAsync(string searchText, int skip, int take)
    {
        try
        {
            var normalizedSearchText = searchText.ToUpperInvariant();
            var users = await this.identityContext
                .Users
                .Where(x => normalizedSearchText.Contains(x.NormalizedEmail))
                .OrderBy(x => x.NormalizedEmail)
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return await this.MapUsersAsync(users);
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "Fetching users failed");
            return new List<EmUserModel>();
        }
    }

    /// <inheritdoc/>
    public async Task<int> CountUsersAsync(string searchText)
    {
        try
        {
            var normalizedSearchText = searchText.ToUpperInvariant();
            return await this.identityContext
                .Users
                .Where(x => normalizedSearchText.Contains(x.NormalizedEmail))
                .CountAsync();
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "Counting users failed");
            return 0;
        }
    }

    /// <inheritdoc/>
    public async Task<EmAuthResult> RetrieveAccessTokenAsync(IEmTokenBaseCredentialsRequest request)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(request);

            var defaultErrorResult = new EmAuthResult
            {
                Message = Strings.WrongEmailOrPassword,
            };

            var user = await this.userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                return defaultErrorResult;
            }

            if (!await this.userManager.CheckPasswordAsync(user, request.Password))
            {
                return defaultErrorResult;
            }

            var hasActivatedMfa = await this.userManager.GetTwoFactorEnabledAsync(user);

            return new EmAuthResult
            {
                Succeeded = true,
                Message = Strings.AuthenticationSucceeded,
                AccessToken = hasActivatedMfa ? null : await this.BuildJwtTokenForUserAsync(user),
                PostAuthenticationToken = hasActivatedMfa ? "postToken" : null,
            };
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "An unexpected error during login");
            return new EmAuthResult
            {
                Message = Strings.AnUnexpectedErrorOccurred,
            };
        }
    }

    /// <inheritdoc/>
    public async Task<EmAuthResult> RetrieveAccessTokenAsync(IEmTokenMfaBasedCredentialsRequest request)
    {
        throw new NotImplementedException();
    }

    private async Task<IEnumerable<EmUserModel>> MapUsersAsync(IEnumerable<EmIdentityUser> users)
    {
        var usersIds = users.Select(x => x.Id);
        var permissionsPerUsers = await this.identityContext
            .UserClaims
            .Where(x => usersIds.Contains(x.UserId) && x.ClaimType == EmIdentityClaimTypes.Permission)
            .GroupBy(x => x.UserId)
            .ToDictionaryAsync(x => x.Key, x => x.Select(xx => xx.ClaimValue));

        var userModels = new List<EmUserModel>();
        foreach (var user in users)
        {
            IEnumerable<string> userPermissions = new List<string>();
            if (permissionsPerUsers.ContainsKey(user.Id))
            {
                userPermissions = permissionsPerUsers[user.Id];
            }

            userModels.Add(this.MapUserToModel(user, userPermissions));
        }

        return userModels;
    }

    private async Task<EmUserModel> MapUserAsync(EmIdentityUser user)
    {
        var userPermissions = await this.identityContext
            .UserClaims
            .Where(x => x.UserId == user.Id && x.ClaimType == EmIdentityClaimTypes.Permission)
            .Select(x => x.ClaimValue)
            .ToListAsync();

        return this.MapUserToModel(user, userPermissions);
    }

    private EmUserModel MapUserToModel(EmIdentityUser user, IEnumerable<string> permissions) =>
        new ()
        {
            Id = user.Id,
            Email = user.Email,
            TwoFactorEnabled = user.TwoFactorEnabled,
            IsLockedOut = user.LockoutEnabled && user.LockoutEnd >= DateTimeOffset.UtcNow,
            Permissions = permissions,
        };

    private async Task<string> BuildJwtTokenForUserAsync(EmIdentityUser user) =>
        this.BuildJwtToken(await this.GetUserClaimsForJwtTokenAsync(user));

    private async Task<IEnumerable<Claim>> GetUserClaimsForJwtTokenAsync(EmIdentityUser user)
    {
        try
        {
            var claims = await this.userManager.GetClaimsAsync(user);
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));

            return claims;
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "An error occured during getting user claims for JWT");
            return default;
        }
    }

    private string BuildJwtToken(IEnumerable<Claim> claims)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.identityOptions.AccessTokenSecurityKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var expirationDate = DateTime.UtcNow.Add(this.identityOptions.AccessTokenExpirationSpan);

        var token = new JwtSecurityToken(
            issuer: this.identityOptions.AccessTokenIssuer,
            audience: EmConstants.FrameworkId,
            claims,
            expires: expirationDate,
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}