﻿using System;
using Emeraude.Identity.Entities;
using Emeraude.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Emeraude.Identity.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds Emeraude Framework identity services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddEmeraudeIdentity(this IServiceCollection services, IEmIdentityOptions options)
    {
        services.AddDbContext<IdentityContext>(options.DbContextOptionsBuilder);

        services
            .AddIdentityCore<User>()
            .AddEntityFrameworkStores<IdentityContext>()
            .AddDefaultTokenProviders();

        services.AddDataProtection();

        services.TryAddScoped<IEmIdentityService, IdentityService>();
        services.TryAddTransient<IEmIdentityInitializer, IdentityInitializer>();

        return services;
    }
}