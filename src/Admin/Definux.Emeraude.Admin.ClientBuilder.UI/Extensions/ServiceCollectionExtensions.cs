using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Admin.ClientBuilder.UI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureAdminClientBuilderUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(AdminClientBuilderUIConfigureOptions));

            return services;
        }
    }
}
