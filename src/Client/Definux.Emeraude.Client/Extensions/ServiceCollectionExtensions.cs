using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Definux.Emeraude.Client.Adapters;
using Definux.Emeraude.Client.UI.Adapters;
using Definux.Emeraude.Client.UI.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Essentials.Base;
using Definux.Emeraude.Locales.Constraints;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
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
        /// <param name="clientOptions"></param>
        public static void AddEmeraudeClient(this IServiceCollection services, EmClientOptions clientOptions)
        {
            services.ConfigureClientUI();
            services.AddRouting(opt =>
            {
                opt.ConstraintMap.Add(LanguageRouteConstraint.LanguageConstraintKey, typeof(LanguageRouteConstraint));
            });

            services.AddScoped<IExternalAuthenticationProvidersCollection, ExternalAuthenticationProvidersCollection>();

            services.AddScoped(typeof(ISitemapComposition), clientOptions.SitemapCompositionType);
        }

        /// <summary>
        /// Register client authentication scheme.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddClientCookie(this AuthenticationBuilder builder)
        {
            builder
                .AddCookie(EmAuthenticationDefaults.ClientAuthenticationScheme, options =>
                {
                    options.LoginPath = "/login";
                    options.LogoutPath = "/";
                    options.ExpireTimeSpan = TimeSpan.FromDays(7);
                    options.Cookie.Name = EmAuthenticationDefaults.ClientCookieName;
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
