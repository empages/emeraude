using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Admin.Analytics.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configure Admin Analytics UI.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureAdminAnalyticsUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(AdminAnalyticsUIConfigureOptions));

            return services;
        }
    }
}
