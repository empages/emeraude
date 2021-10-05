using System;
using System.Collections.Generic;
using Definux.Emeraude.ClientBuilder.Options;
using Definux.Emeraude.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.ClientBuilder.Services;
using Definux.Emeraude.ClientBuilder.Shared;
using Definux.Emeraude.Essentials.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.ClientBuilder.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register Client Builder services.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="clientBuilderOptions"></param>
        public static void RegisterClientBuilder(this IServiceCollection services, EmClientBuilderOptions clientBuilderOptions)
        {
            services.AddScoped<IEndpointService, EndpointService>();
            services.AddScoped<IScaffoldModulesFactory, ScaffoldModulesFactory>();

            services.AddCors(options =>
            {
                options.AddPolicy(ClientBuilderConstants.CorsPolicyName, builder =>
                {
                    builder
                        .WithOrigins(ClientBuilderConstants.WebClientOrigins)
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            foreach (var modulesType in clientBuilderOptions.ModulesTypes)
            {
                services.AddScoped(modulesType);
            }
        }
    }
}