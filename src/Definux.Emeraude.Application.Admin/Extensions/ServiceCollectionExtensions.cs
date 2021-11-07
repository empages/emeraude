using Definux.Emeraude.Application.Admin.Adapters;
using Definux.Emeraude.Application.Admin.EmPages.Extensions;
using Definux.Emeraude.Configuration.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Application.Admin.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register all required Emeraude administration services.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="adminOptions"></param>
        /// <param name="mainOptions"></param>
        public static void AddEmeraudeAdmin(
            this IServiceCollection services,
            EmAdminOptions adminOptions,
            EmMainOptions mainOptions)
        {
            services.AddRouting();

            services.RegisterAdapters(adminOptions);

            services.RegisterEmPages(mainOptions.Assemblies);
        }

        private static void RegisterAdapters(this IServiceCollection services, EmAdminOptions options)
        {
            services.AddScoped(typeof(IAdminMenusBuilder), options.AdminMenusBuilderType);
        }
    }
}
