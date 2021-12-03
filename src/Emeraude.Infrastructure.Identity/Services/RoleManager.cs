using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Emeraude.Contracts;
using Emeraude.Essentials.Base;
using Emeraude.Infrastructure.Identity.Common;
using Emeraude.Infrastructure.Identity.Entities;
using Emeraude.Infrastructure.Identity.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.Identity.Services
{
    /// <inheritdoc cref="IRoleManager"/>
    public class RoleManager : IRoleManager
    {
        private readonly ILogger<RoleManager> logger;
        private readonly RoleManager<Role> roleManager;
        private readonly UserManager<User> userManager;
        private readonly IIdentityContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleManager"/> class.
        /// </summary>
        /// <param name="roleManager"></param>
        /// <param name="userManager"></param>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        public RoleManager(
            RoleManager<Role> roleManager,
            UserManager<User> userManager,
            IIdentityContext context,
            ILogger<RoleManager> logger)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.context = context;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<Dictionary<Guid, string>> GetRolesAsync()
        {
            try
            {
                return await this.context.Roles.ToDictionaryAsync(k => k.Id, v => v.Name);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during getting roles");
                return new Dictionary<Guid, string>();
            }
        }

        /// <inheritdoc/>
        public async Task<bool> CreateRoleAsync(string roleName, IEnumerable<string> claims)
        {
            try
            {
                if (claims == null)
                {
                    claims = new string[] { };
                }

                var role = await this.roleManager.FindByNameAsync(roleName);
                if (role == null)
                {
                    role = new Role(roleName);
                    var result = await this.roleManager.CreateAsync(role);
                    if (!result.Succeeded)
                    {
                        return false;
                    }

                    foreach (string claim in claims.Distinct())
                    {
                        result = await this.roleManager.AddClaimAsync(role, new Claim(EmClaimTypes.Permission, claim));

                        if (!result.Succeeded)
                        {
                            await this.DeleteRoleAsync(role.Name);
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during creating role");
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteRoleAsync(string roleName)
        {
            try
            {
                var role = await this.roleManager.FindByNameAsync(roleName);

                if (role != null)
                {
                    await this.roleManager.DeleteAsync(role);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during deleting role");
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<Dictionary<Guid, string>> GetUserRolesAsync(IUser user)
        {
            try
            {
                var userRoles = await this.userManager.GetRolesAsync((User)user);

                return await this.context
                    .Roles
                    .Where(x => userRoles.Contains(x.Name))
                    .ToDictionaryAsync(k => k.Id, v => v.Name);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during getting user roles");
                return new Dictionary<Guid, string>();
            }
        }

        /// <inheritdoc/>
        public async Task<bool> RemoveAllRolesFromUserAsync(IUser user)
        {
            try
            {
                var userRoles = await this.userManager.GetRolesAsync((User)user);
                var result = await this.userManager.RemoveFromRolesAsync((User)user, userRoles);

                return result.Succeeded;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during removing the roles of user");
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> AssignRolesToUserAsync(IUser user, IEnumerable<Guid> roleIds)
        {
            try
            {
                var rolesToAssign = await this.context
                    .Roles
                    .Where(x => roleIds.Contains(x.Id))
                    .ToListAsync();

                var result = await this.userManager.AddToRolesAsync((User)user, rolesToAssign?.Select(x => x.Name));

                return result.Succeeded;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during roles assignment to the user");
                return false;
            }
        }
    }
}
