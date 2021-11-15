using System.Linq;
using Emeraude.Presentation.PortalGateway.ActionFilters;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Presentation.PortalGateway.Extensions
{
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
}