using System.Linq;
using Emeraude.Presentation.PortalGateway.ActionFilters;
using Emeraude.Presentation.PortalGateway.Options;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Presentation.PortalGateway.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers Emeraude portal gateway.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="gatewayOptions"></param>
    public static void RegisterEmeraudePortalGateway(this IServiceCollection services, EmPortalGatewayOptions gatewayOptions)
    {
        services.AddScoped<PortalFilterAttribute>();

        foreach (var (strategy, implementation) in gatewayOptions.IdentityActionsStrategies)
        {
            services.AddTransient(strategy, implementation);
        }

        services.AddCors(options =>
        {
            options.AddPolicy(EmPortalConstants.CorsPolicyName, builder =>
            {
                builder
                    .WithOrigins(gatewayOptions.PortalUrls.ToArray())
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
    }
}