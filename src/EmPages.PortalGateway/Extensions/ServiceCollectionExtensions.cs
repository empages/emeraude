using System.Linq;
using System.Reflection;
using EmPages.PortalGateway.ActionFilters;
using EmPages.PortalGateway.Controllers;
using EmPages.PortalGateway.Services;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;

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
        services.AddSingleton<IGatewayEndpointsRetriever, GatewayEndpointRetriever>();
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