using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureAdminUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(AdminUIConfigureOptions));

            return services;
        }
    }
}
