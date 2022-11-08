using System;
using EmPages.Identity.Entities;
using EmPages.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EmPages.Identity.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds EmPages Framework identity services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddEmeraudeIdentity(this IServiceCollection services, IEmIdentityOptions options)
    {
        services.AddDbContext<EmIdentityContext>(options.DbContextOptionsBuilder);

        services
            .AddIdentityCore<EmIdentityUser>()
            .AddEntityFrameworkStores<EmIdentityContext>()
            .AddDefaultTokenProviders();

        services.AddDataProtection();

        services.TryAddScoped<EmUserManager>();
        services.TryAddScoped<IEmIdentityService, EmIdentityService>();
        services.TryAddTransient<IEmIdentityInitializer, EmIdentityInitializer>();

        return services;
    }
}