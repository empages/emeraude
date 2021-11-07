using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Contracts;
using Definux.Emeraude.Infrastructure.Identity.Common;
using Definux.Emeraude.Infrastructure.Identity.Entities;
using Definux.Emeraude.Infrastructure.Identity.Extensions;
using Definux.Emeraude.Infrastructure.Identity.Models;
using Definux.Emeraude.Infrastructure.Identity.Options;
using Definux.Emeraude.Infrastructure.Identity.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Definux.Emeraude.Infrastructure.Identity.Services
{
    /// <inheritdoc cref="IUserTokensService"/>
    public class UserTokensService : IUserTokensService
    {
        private readonly UserManager<User> userManager;
        private readonly IIdentityContext context;
        private readonly IUserClaimsService userClaimsService;
        private readonly EmIdentityOptions identityOptions;
        private readonly JsonWebTokenOptions jwtOptions;
        private readonly ILogger<UserTokensService> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTokensService"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="context"></param>
        /// <param name="userClaimsService"></param>
        /// <param name="jsonWebTokenOptions"></param>
        /// <param name="optionsProvider"></param>
        /// <param name="logger"></param>
        public UserTokensService(
            UserManager<User> userManager,
            IIdentityContext context,
            IUserClaimsService userClaimsService,
            IOptions<JsonWebTokenOptions> jsonWebTokenOptions,
            IEmOptionsProvider optionsProvider,
            ILogger<UserTokensService> logger)
        {
            this.userManager = userManager;
            this.context = context;
            this.userClaimsService = userClaimsService;
            this.identityOptions = optionsProvider.GetIdentityOptions();
            this.jwtOptions = jsonWebTokenOptions.Value;
            this.logger = logger;
        }

        /// <inheritdoc />
        public async Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(Guid userId, TimeSpan? expiration = null)
            => await this.BuildJwtTokenForUserAsync(await this.userManager.FindByIdAsync(userId.ToString()), expiration);

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(string userEmail, TimeSpan? expiration = null)
            => await this.BuildJwtTokenForUserAsync(await this.userManager.FindByEmailAsync(userEmail), expiration);

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(IUser user, TimeSpan? expiration = null)
        {
            try
            {
                var userClaims = await this.userClaimsService.GetUserClaimsForJwtTokenAsync(user.Id);
                var jwt = this.BuildJwtToken(userClaims, expiration.HasValue ? (int)expiration.Value.TotalSeconds : null);
                string refreshToken = StaticFunctions.GenerateRefreshToken();
                var refreshTokenExpiration = DateTime.UtcNow.AddSeconds(this.identityOptions.RefreshTokenExpiration);

                var userInstance = (User)user;
                userInstance.RefreshToken = refreshToken;
                userInstance.RefreshTokenExpiration = refreshTokenExpiration;
                await this.userManager.UpdateAsync(userInstance);

                return BearerAuthenticationResult.SuccessResult(jwt, refreshToken, refreshTokenExpiration);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during building JWT token for a user");
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> BuildJwtTokenForExternalUserAsync(IExternalUser externalUser, TimeSpan? expiration = null)
        {
            try
            {
                var user = await this.userManager.FindByLoginAsync(externalUser.Provider, externalUser.Id);

                return await this.BuildJwtTokenForUserAsync(user.Id, expiration);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during building JWT token for a external user");
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> RefreshJwtTokenAsync(Guid? userId, string refreshToken)
        {
            User user = null;
            if (userId.HasValue)
            {
                user = await this.userManager.FindByIdAsync(userId.ToString());
            }
            else
            {
                user = await this.context.Users.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);
            }

            if (user != null && user.RefreshToken == refreshToken && user.RefreshTokenExpiration.HasValue && user.RefreshTokenExpiration > DateTime.UtcNow)
            {
                var userClaims = await this.userClaimsService.GetUserClaimsForJwtTokenAsync(user.Id);
                string jwt = this.BuildJwtToken(userClaims);

                return BearerAuthenticationResult.SuccessResult(jwt, refreshToken, user.RefreshTokenExpiration.Value);
            }

            return BearerAuthenticationResult.FailedResult;
        }

        /// <inheritdoc/>
        public async Task<bool> ResetRefreshTokenAsync(Guid userId)
        {
            var user = await this.userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                user.RefreshToken = null;
                user.RefreshTokenExpiration = null;
                await this.userManager.UpdateAsync(user);

                return true;
            }

            return false;
        }

        private string BuildJwtToken(List<Claim> claims, int? accessTokenExpiration = null)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.jwtOptions.Key));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenExpirationSeconds = accessTokenExpiration ?? this.identityOptions.AccessTokenExpiration;
            DateTime expirationDate = DateTime.UtcNow.AddSeconds(tokenExpirationSeconds);

            var token = new JwtSecurityToken(
                this.jwtOptions.Issuer,
                this.jwtOptions.Issuer,
                claims,
                expires: expirationDate,
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
