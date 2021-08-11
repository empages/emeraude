using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.ClientBuilder.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configure Client Builder UI.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureAdminClientBuilderUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(AdminClientBuilderUIConfigureOptions));

            return services;
        }
    }
}
