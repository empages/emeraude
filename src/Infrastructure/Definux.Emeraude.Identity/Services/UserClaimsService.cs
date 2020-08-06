using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Identity.Services
{
    public class UserClaimsService : IUserClaimsService
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly ILogger logger;

        public UserClaimsService(
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            ILogger logger)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.logger = logger;
        }


        public async Task<bool> CheckUserForAccessAdministrationPermissionAsync(string email)
        {
            try
            {
                var user = await this.userManager.FindByEmailAsync(email);
                
                var userClaims = await this.GetAllUserClaimsAsync(user);
                string claimType = Configuration.Authorization.ClaimTypes.Permission;
                string claimValue = AdminPermissions.AccessAdministration;

                return userClaims != null && userClaims.Any(x => x.Type == claimType && x.Value == claimValue);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return false;
            }
        }

        public async Task<List<Claim>> GetUserClaimsForCookieAsync(Guid userId)
        {
            try
            {
                var user = await this.userManager.FindByIdAsync(userId.ToString());
                var claims = await GetAllUserClaimsAsync(user);
                claims.Add(new Claim(System.Security.Claims.ClaimTypes.NameIdentifier, user.Id.ToString()));
                claims.Add(new Claim(System.Security.Claims.ClaimTypes.Name, user.Email));
                claims.Add(new Claim(System.Security.Claims.ClaimTypes.Email, user.Email));

                return claims?.ToList();
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return default;
            }
        }

        public async Task<List<Claim>> GetUserClaimsForJwtTokenAsync(Guid userId)
        {
            try
            {
                var user = await this.userManager.FindByIdAsync(userId.ToString());
                var claims = await GetAllUserClaimsAsync(user);
                claims.Add(new Claim(JwtRegisteredClaimNames.Jti, user.Id.ToString()));
                claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Email));

                return claims;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return default;
            }
        }

        private async Task<List<Claim>> GetAllUserClaimsAsync(IUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user", "User cannot be null.");
            }

            var userClaims = await this.userManager.GetClaimsAsync((User)user);
            var userRoles = await this.userManager.GetRolesAsync((User)user);
            var rolesClaims = await GetRolesClaimsAsync(userRoles);
            var resultClaims = userClaims?.ToList();

            resultClaims.AddRange(rolesClaims);

            return DistinctClaims(resultClaims);
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

            return DistinctClaims(rolesClaims);
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
