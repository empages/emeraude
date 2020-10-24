using System;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Persistence.Seed
{
    /// <inheritdoc cref="IApplicationDatabaseInitializer"/>
    public class ApplicationDatabaseInitializer : IApplicationDatabaseInitializer
    {
        private readonly IEmContext context;
        private readonly IUserManager userManager;
        private readonly IRoleManager roleManager;
        private readonly EmOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDatabaseInitializer"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        /// <param name="optionsAccessor"></param>
        public ApplicationDatabaseInitializer(
            IEmContext context,
            IUserManager userManager,
            IRoleManager roleManager,
            IOptions<EmOptions> optionsAccessor)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.options = optionsAccessor.Value;
        }

        /// <inheritdoc/>
        public async Task SeedAsync()
        {
            if (!await this.context.Set<Role>().AsQueryable().AnyAsync())
            {
                await this.EnsureRoleAsync(ApplicationRoles.Admin, AdminPermissions.GetAllPermissionValues());
                await this.EnsureRoleAsync(ApplicationRoles.User, new string[] { });
                if (this.options.AdditonalRoles != null && this.options.AdditonalRoles.Count > 0)
                {
                    foreach (var role in this.options.AdditonalRoles)
                    {
                        await this.EnsureRoleAsync(role.Key, role.Value);
                    }
                }
            }

            if (!await this.context.Set<User>().AsQueryable().AnyAsync())
            {
                await this.CreateUserAsync(
                    EmIdentityConstants.DefaultEmeraudeAdminEmail,
                    EmIdentityConstants.DefaultEmeraudeAdminPassword,
                    EmIdentityConstants.DefaultEmeraudeAdminName,
                    new string[] { ApplicationRoles.Admin });

                await this.CreateUserAsync(
                    EmIdentityConstants.DefaultEmeraudeUserEmail,
                    EmIdentityConstants.DefaultEmeraudeUserPassword,
                    EmIdentityConstants.DefaultEmeraudeUserName,
                    new string[] { ApplicationRoles.User });
            }
        }

        private async Task EnsureRoleAsync(string roleName, string[] claims)
        {
            if (!await this.context.Set<Role>().AsQueryable().Where(x => x.Name == roleName).AnyAsync())
            {
                var result = await this.roleManager.CreateRoleAsync(roleName, claims);
            }
        }

        private async Task<User> CreateUserAsync(string email, string password, string name, string[] roles)
        {
            User user = new User
            {
                UserName = email,
                Email = email,
                Name = name,
                EmailConfirmed = true,
                RegistrationDate = DateTime.Now,
                LockoutEnabled = true,
            };

            var result = await this.userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                await this.userManager.AddToRolesAsync(user, roles);
            }

            return user;
        }
    }
}