using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Options;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Definux.Emeraude.Admin.ClientBuilder.Extensions
{
    public static class ServiceCollectionExtensions
    {
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

            services.Configure<ClientBuilderOptions>(options =>
            {
                options.Assemblies = builderOptions.Assemblies;
                options.WebAppPath = builderOptions.WebAppPath;
                options.MobileAppPath = builderOptions.MobileAppPath;
                options.ModulesTypes = builderOptions.ModulesTypes;
            });

            services.AddScoped<IPageService, PageService>();
            services.AddScoped<IEndpointService, EndpointService>();

            services.AddScoped<IScaffoldModulesProvider, ScaffoldModulesProvider>();

            return services;
        }
    }
}
