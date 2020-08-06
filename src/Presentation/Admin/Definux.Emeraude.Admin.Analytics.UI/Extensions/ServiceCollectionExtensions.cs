using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Admin.Analytics.UI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureAdminAnalyticsUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(AdminAnalyticsUIConfigureOptions));

            return services;
        }
    }
}
