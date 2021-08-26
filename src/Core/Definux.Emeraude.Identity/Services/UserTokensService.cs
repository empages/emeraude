﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Identity.Extensions;
using Definux.Emeraude.Identity.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Definux.Emeraude.Identity.Services
{
    /// <inheritdoc cref="IUserTokensService"/>
    public class UserTokensService : IUserTokensService
    {
        private readonly UserManager<User> userManager;
        private readonly IEmContext context;
        private readonly IUserClaimsService userClaimsService;
        private readonly EmIdentityOptions identityOptions;
        private readonly JsonWebTokenOptions jwtOptions;
        private readonly IEmLogger logger;

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
            IEmContext context,
            IUserClaimsService userClaimsService,
            IOptions<JsonWebTokenOptions> jsonWebTokenOptions,
            IEmOptionsProvider optionsProvider,
            IEmLogger logger)
        {
            this.userManager = userManager;
            this.context = context;
            this.userClaimsService = userClaimsService;
            this.identityOptions = optionsProvider.GetIdentityOptions();
            this.jwtOptions = jsonWebTokenOptions.Value;
            this.logger = logger;
        }

        /// <inheritdoc />
        public async Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(Guid userId)
            => await this.BuildJwtTokenForUserAsync(await this.userManager.FindByIdAsync(userId.ToString()));

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(string userEmail)
            => await this.BuildJwtTokenForUserAsync(await this.userManager.FindByEmailAsync(userEmail));

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(IUser user)
        {
            try
            {
                var userClaims = await this.userClaimsService.GetUserClaimsForJwtTokenAsync(user.Id);
                var jwt = this.BuildJwtToken(userClaims);
                var (refreshToken, refreshTokenExpiration) = this.context.BuildRefreshToken((User)user, this.identityOptions.RefreshTokenExpiration);
                await this.context.SaveChangesAsync();

                return BearerAuthenticationResult.SuccessResult(jwt, refreshToken, refreshTokenExpiration.Value);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return null;
            }
        }

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> BuildJwtTokenForExternalUserAsync(IExternalUser externalUser)
        {
            try
            {
                var user = await this.userManager.FindByLoginAsync(externalUser.Provider, externalUser.Id);

                return await this.BuildJwtTokenForUserAsync(user.Id);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
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
                user = await this.context.Set<User>().AsQueryable().FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);
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
                this.context.ResetRefreshToken(user);
                await this.context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        private string BuildJwtToken(List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.jwtOptions.Key));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            DateTime expirationDate = DateTime.UtcNow.AddSeconds(this.identityOptions.AccessTokenExpiration);

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
