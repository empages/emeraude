using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmPages.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmPages.Identity.Services;

/// <inheritdoc />
internal class IdentityService : IEmIdentityService
{
    private readonly UserManager<User> userManager;
    private readonly IdentityContext identityContext;
    private readonly ILogger<IdentityService> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityService"/> class.
    /// </summary>
    /// <param name="userManager"></param>
    /// <param name="identityContext"></param>
    /// <param name="logger"></param>
    public IdentityService(
        UserManager<User> userManager,
        IdentityContext identityContext,
        ILogger<IdentityService> logger)
    {
        this.userManager = userManager;
        this.identityContext = identityContext;
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
                .Where(x => normalizedSearchText.Contains(x.NormalizedName) ||
                            normalizedSearchText.Contains(x.NormalizedEmail))
                .OrderBy(x => x.Name)
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
                .Where(x => normalizedSearchText.Contains(x.NormalizedName) ||
                            normalizedSearchText.Contains(x.NormalizedEmail))
                .CountAsync();
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "Counting users failed");
            return 0;
        }
    }

    private async Task<IEnumerable<EmUserModel>> MapUsersAsync(IEnumerable<User> users)
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

    private async Task<EmUserModel> MapUserAsync(User user)
    {
        var userPermissions = await this.identityContext
            .UserClaims
            .Where(x => x.UserId == user.Id && x.ClaimType == EmIdentityClaimTypes.Permission)
            .Select(x => x.ClaimValue)
            .ToListAsync();

        return this.MapUserToModel(user, userPermissions);
    }

    private EmUserModel MapUserToModel(User user, IEnumerable<string> permissions) =>
        new ()
        {
            Id = user.Id,
            Email = user.Email,
            Name = user.Name,
            TwoFactorEnabled = user.TwoFactorEnabled,
            IsLockedOut = user.LockoutEnabled && user.LockoutEnd >= DateTimeOffset.UtcNow,
            Permissions = permissions,
        };
}