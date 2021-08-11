using System;
using AutoMapper;
using Definux.Emeraude.Client.Adapters;
using Definux.Emeraude.Client.UI.Adapters;
using Definux.Emeraude.Client.UI.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Locales.Constraints;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Client.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register client features.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddEmeraudeClient(this IServiceCollection services)
        {
            services.ConfigureClientUI();
            services.AddRouting(options =>
            {
                options.ConstraintMap.Add(LanguageRouteConstraint.LanguageConstraintKey, typeof(LanguageRouteConstraint));
            });

            services.AddScoped<IExternalAuthenticationProvidersCollection, ExternalAuthenticationProvidersCollection>();

            return services;
        }

        /// <summary>
        /// Register client authentication scheme.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddClientCookie(this AuthenticationBuilder builder)
        {
            builder
                .AddCookie(AuthenticationDefaults.ClientAuthenticationScheme, options =>
                {
                    options.LoginPath = "/login";
                    options.LogoutPath = "/";
                    options.ExpireTimeSpan = TimeSpan.FromDays(7);
                    options.Cookie.Name = AuthenticationDefaults.ClientCookieName;
                });

            return builder;
        }

        /// <summary>
        /// Register client mapper configuration.
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IMapperConfigurationExpression AddClientMapperConfiguration(this IMapperConfigurationExpression configuration)
        {
            return configuration;
        }
    }
}
