using EmPages.Identity.Entities;
using EmPages.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EmPages.Identity;

/// <summary>
/// EmPages Identity dependency module injector.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds EmPages Framework identity services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddIdentity(this IServiceCollection services, IEmIdentityOptions options)
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