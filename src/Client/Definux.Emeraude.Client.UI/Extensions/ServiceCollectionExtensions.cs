using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Client.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configure Client UI.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureClientUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(ClientUIConfigureOptions));

            return services;
        }
    }
}
