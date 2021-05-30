using System;
using System.Reflection;
using Definux.Emeraude.Admin.ClientBuilder.Options;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Admin.ClientBuilder.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registration and configuration of Client Builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Exception in case options are missing.</exception>
        public static IServiceCollection AddEmeraudeClientBuilder(this IServiceCollection services, Action<ClientBuilderOptions> optionsAction)
        {
            ClientBuilderOptions builderOptions = new ClientBuilderOptions();
            if (optionsAction == null)
            {
                throw new ArgumentException("Client builder options are not initialized correctly.");
            }

            optionsAction.Invoke(builderOptions);

            var applicationAssembly = Assembly.GetCallingAssembly().GetName().Name;
            var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetService<IConfiguration>();

            services.Configure(optionsAction);

            services.AddScoped<IPageService, PageService>();
            services.AddScoped<IEndpointService, EndpointService>();

            services.AddScoped<IScaffoldModulesProvider, ScaffoldModulesProvider>();

            return services;
        }
    }
}
