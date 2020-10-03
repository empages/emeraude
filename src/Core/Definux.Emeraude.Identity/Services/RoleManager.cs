using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Identity.Services
{
    /// <inheritdoc cref="IRoleManager"/>
    public class RoleManager : IRoleManager
    {
        private readonly Application.Common.Interfaces.Logging.ILogger logger;
        private readonly RoleManager<Role> roleManager;
        private readonly UserManager<User> userManager;
        private readonly IEmContext context;

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
            IEmContext context,
            Application.Common.Interfaces.Logging.ILogger logger)
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
                return await this.context.Set<Role>().ToDictionaryAsync(k => k.Id, v => v.Name);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
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
                        result = await this.roleManager.AddClaimAsync(role, new Claim(Definux.Emeraude.Configuration.Authorization.ClaimTypes.Permission, claim));

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
                await this.logger.LogErrorAsync(ex);
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
                await this.logger.LogErrorAsync(ex);
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
                    .Set<Role>()
                    .Where(x => userRoles.Contains(x.Name))
                    .ToDictionaryAsync(k => k.Id, v => v.Name);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return new Dictionary<Guid, string>();
            }
        }

        /// <inheritdoc/>
        public async Task<bool> UnassignAllRolesFromUserAsync(IUser user)
        {
            try
            {
                var userRoles = await this.userManager.GetRolesAsync((User)user);
                var result = await this.userManager.RemoveFromRolesAsync((User)user, userRoles);

                return result.Succeeded;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> AssignRolesToUserAsync(IUser user, IEnumerable<Guid> roleIds)
        {
            try
            {
                var rolesToAssign = await this.context
                    .Set<Role>()
                    .Where(x => roleIds.Contains(x.Id))
                    .ToListAsync();

                var result = await this.userManager.AddToRolesAsync((User)user, rolesToAssign?.Select(x => x.Name));

                return result.Succeeded;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return false;
            }
        }
    }
}
