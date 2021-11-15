using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Emeraude.Contracts;
using Emeraude.Essentials.Base;
using Emeraude.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.Identity.Services
{
    /// <inheritdoc cref="IUserClaimsService"/>
    public class UserClaimsService : IUserClaimsService
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly ILogger<UserClaimsService> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserClaimsService"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        /// <param name="logger"></param>
        public UserClaimsService(
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            ILogger<UserClaimsService> logger)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> CheckUserForAccessAdministrationPermissionAsync(string email)
        {
            try
            {
                var user = await this.userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    return false;
                }

                var userClaims = await this.GetAllUserClaimsAsync(user);
                string claimType = EmClaimTypes.Permission;
                string claimValue = EmPermissions.AccessAdministration;

                return userClaims != null && userClaims.Any(x => x.Type == claimType && x.Value == claimValue);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during checking user for administration permission");
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<List<Claim>> GetUserClaimsForCookieAsync(Guid userId)
        {
            try
            {
                var user = await this.userManager.FindByIdAsync(userId.ToString());
                var claims = await this.GetAllUserClaimsAsync(user);
                claims.Add(new Claim(System.Security.Claims.ClaimTypes.NameIdentifier, user.Id.ToString()));
                claims.Add(new Claim(System.Security.Claims.ClaimTypes.Name, user.Email));
                claims.Add(new Claim(System.Security.Claims.ClaimTypes.Email, user.Email));

                return claims?.ToList();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during getting user claims from cookie");
                return default;
            }
        }

        /// <inheritdoc/>
        public async Task<List<Claim>> GetUserClaimsForJwtTokenAsync(Guid userId)
        {
            try
            {
                var user = await this.userManager.FindByIdAsync(userId.ToString());
                var claims = await this.GetAllUserClaimsAsync(user);
                claims.Add(new Claim(JwtRegisteredClaimNames.Jti, user.Id.ToString()));
                claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Email));

                return claims;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during getting user claims for JWT");
                return default;
            }
        }

        /// <inheritdoc/>
        public async Task<List<Claim>> GetAllUserClaimsAsync(IUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user", "User cannot be null.");
            }

            var userClaims = await this.userManager.GetClaimsAsync((User)user);
            var userRoles = await this.userManager.GetRolesAsync((User)user);
            var rolesClaims = await this.GetRolesClaimsAsync(userRoles);
            var resultClaims = userClaims?.ToList();

            resultClaims.AddRange(rolesClaims);

            return this.DistinctClaims(resultClaims);
        }

        private async Task<List<Claim>> GetRolesClaimsAsync(IList<string> roles)
        {
            var rolesClaims = new List<Claim>();
            foreach (var role in roles)
            {
                var currentRole = await this.roleManager.FindByNameAsync(role);
                var currentRoleClaims = await this.roleManager.GetClaimsAsync(currentRole);

                rolesClaims.Add(new Claim(System.Security.Claims.ClaimTypes.Role, currentRole.Name));
                foreach (var currentRoleClaim in currentRoleClaims)
                {
                    rolesClaims.Add(currentRoleClaim);
                }
            }

            return this.DistinctClaims(rolesClaims);
        }

        private List<Claim> DistinctClaims(List<Claim> claims)
        {
            var distinctedClaims = new List<Claim>();
            foreach (var claim in claims)
            {
                if (!distinctedClaims.Any(x => x.Type == claim.Type && x.Value == claim.Value))
                {
                    distinctedClaims.Add(claim);
                }
            }

            return distinctedClaims;
        }
    }
}
