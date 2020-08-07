using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Application.Common.Results;
using Definux.Emeraude.Application.Common.Results.Identity;
using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Identity.Extensions;
using Definux.Utilities.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Definux.Emeraude.Identity.Services
{
    public class UserTokensService : IUserTokensService
    {
        private readonly UserManager<User> userManager;
        private readonly IEmContext context;
        private readonly IUserClaimsService userClaimsService;
        private readonly JsonWebTokenOptions jwtOptions;
        private readonly ILogger logger;

        public UserTokensService(
            UserManager<User> userManager,
            IEmContext context,
            IUserClaimsService userClaimsService, 
            IOptions<JsonWebTokenOptions> jsonWebTokenOptions,
            ILogger logger)
        {
            this.userManager = userManager;
            this.context = context;
            this.userClaimsService = userClaimsService;
            this.jwtOptions = jsonWebTokenOptions.Value;
            this.logger = logger;
        }

        public async Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(Guid userId)
        {
            try
            {
                var user = await this.userManager.FindByIdAsync(userId.ToString());
                var userClaims = await this.userClaimsService.GetUserClaimsForJwtTokenAsync(userId);
                string jwt = BuildJwtToken(userClaims);
                string refreshToken = this.context.BuildRefreshToken(user);
                await this.context.SaveChangesAsync();

                return BearerAuthenticationResult.SuccessResult(jwt, refreshToken);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return null;
            }
        }

        public async Task<BearerAuthenticationResult> BuildJwtTokenForExternalUserAsync(IExternalUser externalUser)
        {
            try
            {
                var user = await this.userManager.FindByLoginAsync(externalUser.Provider, externalUser.Id);

                return await BuildJwtTokenForUserAsync(user.Id);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return null;
            }
            
        }

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

            if (user != null && user.RefreshToken == refreshToken && user.RefreshTokenExpiration.HasValue && user.RefreshTokenExpiration > DateTime.Now)
            {
                var userClaims = await this.userClaimsService.GetUserClaimsForJwtTokenAsync(user.Id);
                string jwt = BuildJwtToken(userClaims);

                return BearerAuthenticationResult.SuccessResult(jwt, refreshToken);
            }

            return BearerAuthenticationResult.FailedResult;
        }

        public async Task<bool> ResetRefreshTokenAsync(Guid userId)
        {
            var user = await this.userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                context.ResetRefreshToken(user);
                await this.context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        private string BuildJwtToken(List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.jwtOptions.Key));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            DateTime expirationDate;
            expirationDate = DateTime.Now.AddMinutes(15);

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
