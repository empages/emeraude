using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Definux.Emeraude.Persistence.Seed
{
    public class ApplicationDatabaseInitializer : IApplicationDatabaseInitializer
    {
        private readonly IEmContext context;
        private readonly IUserManager userManager;
        private readonly IRoleManager roleManager;
        private readonly EmOptions options;

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

        public async Task SeedAsync()
        {
            if (!await this.context.Set<Role>().AsQueryable().AnyAsync())
            {
                await EnsureRoleAsync(ApplicationRoles.Admin, AdminPermissions.GetAllPermissionValues());
                await EnsureRoleAsync(ApplicationRoles.User, new string[] { });
                if (this.options.AdditonalRoles != null && this.options.AdditonalRoles.Count > 0)
                {
                    foreach (var role in this.options.AdditonalRoles)
                    {
                        await EnsureRoleAsync(role.Key, role.Value);
                    }
                }
            }

            if (!await this.context.Set<User>().AsQueryable().AnyAsync())
            {
                await CreateUserAsync("admin@example.com", "Admin123!", "Admin", new string[] { ApplicationRoles.Admin.ToString() });
                await CreateUserAsync("user@example.com", "User123!", "User", new string[] { ApplicationRoles.User.ToString() });
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
                RegistrationDate = DateTime.Now
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
