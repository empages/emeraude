﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Configuration.Options;
using Emeraude.Defaults.Constants;
using Emeraude.Infrastructure.Identity.Common;
using Emeraude.Infrastructure.Identity.Entities;
using Emeraude.Infrastructure.Identity.Extensions;
using Emeraude.Infrastructure.Identity.Options;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Infrastructure.Persistence.Context;
using Emeraude.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;

namespace Emeraude.Defaults.Persistence;

/// <summary>
/// Definition of <see cref="IDatabaseInitializer"/> for the default application data.
/// </summary>
public class ApplicationDatabaseInitializer : IDatabaseInitializer
{
    private readonly IEmContext context;
    private readonly IUserManager userManager;
    private readonly IRoleManager roleManager;
    private readonly EmIdentityOptions identityOptions;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApplicationDatabaseInitializer"/> class.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="userManager"></param>
    /// <param name="roleManager"></param>
    /// <param name="optionsProvider"></param>
    public ApplicationDatabaseInitializer(
        IEmContext context,
        IUserManager userManager,
        IRoleManager roleManager,
        IEmOptionsProvider optionsProvider)
    {
        this.context = context;
        this.userManager = userManager;
        this.roleManager = roleManager;
        this.identityOptions = optionsProvider.GetIdentityOptions();
    }

    /// <inheritdoc/>
    public async Task SeedAsync()
    {
        if (!await this.context.Set<Role>().AnyAsync())
        {
            await this.EnsureRoleAsync(EmRoles.Admin, EmPermissions.GetAllPermissionValues());
            await this.EnsureRoleAsync(EmRoles.User, new string[] { });
            if (this.identityOptions.AdditionalRoles != null && this.identityOptions.AdditionalRoles.Count > 0)
            {
                foreach (var role in this.identityOptions.AdditionalRoles)
                {
                    await this.EnsureRoleAsync(role.Key, role.Value);
                }
            }
        }

        if (!await this.context.Set<User>().AnyAsync())
        {
            await this.CreateUserAsync(
                DefaultUsers.DefaultEmeraudeAdminEmail,
                DefaultUsers.DefaultEmeraudeAdminPassword,
                DefaultUsers.DefaultEmeraudeAdminName,
                new[] { EmRoles.Admin });

            await this.CreateUserAsync(
                DefaultUsers.DefaultEmeraudeUserEmail,
                DefaultUsers.DefaultEmeraudeUserPassword,
                DefaultUsers.DefaultEmeraudeUserName,
                new[] { EmRoles.User });
        }
    }

    private async Task EnsureRoleAsync(string roleName, string[] claims)
    {
        if (!await this.context.Set<Role>().Where(x => x.Name == roleName).AnyAsync())
        {
            await this.roleManager.CreateRoleAsync(roleName, claims);
        }
    }

    private async Task CreateUserAsync(string email, string password, string name, string[] roles)
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
    }
}