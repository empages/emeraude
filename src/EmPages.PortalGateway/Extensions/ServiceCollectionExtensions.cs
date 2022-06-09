using System.Linq;
using EmPages.Identity;
using EmPages.Identity.Entities;
using EmPages.Identity.Services;
using EmPages.PortalGateway.ActionFilters;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EmPages.PortalGateway.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds EmPages Framework portal gateway services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddEmeraudePortalGateway(this IServiceCollection services, IEmPortalGatewayOptions options)
    {
        services.AddScoped<EmPortalFilterAttribute>();
        services.AddCors(corsOptions =>
        {
            corsOptions.AddPolicy(EmPortalGatewayConstants.CorsPolicyName, builder =>
            {
                builder
                    .WithOrigins(options.PortalUrls.ToArray())
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        return services;
    }
}