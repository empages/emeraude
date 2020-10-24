using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configure Admin UI.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureAdminUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(AdminUIConfigureOptions));

            return services;
        }
    }
}
