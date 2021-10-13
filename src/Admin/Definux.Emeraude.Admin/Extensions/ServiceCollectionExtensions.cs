using System;
using System.Collections.Generic;
using System.Reflection;
using AutoMapper;
using Definux.Emeraude.Admin.EmPages.Extensions;
using Definux.Emeraude.Admin.UI;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.Admin.UI.Store;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Essentials.Base;
using Definux.Emeraude.Essentials.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Admin.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register all required Emeraude administration services.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="adminOptions"></param>
        /// <param name="mainOptions"></param>
        public static void AddEmeraudeAdmin(
            this IServiceCollection services,
            EmAdminOptions adminOptions,
            EmMainOptions mainOptions)
        {
            services.ConfigureAdminUI();

            services.AddRouting();

            services.RegisterAdapters(adminOptions);

            services.RegisterEmPages(mainOptions.Assemblies);

            services.RegisterAdminUIStore();
        }

        /// <summary>
        /// Register Emeraude administration authentication scheme.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddAdminCookie(this AuthenticationBuilder builder)
        {
            builder.AddCookie(EmAuthenticationDefaults.AdminAuthenticationScheme, options =>
            {
                options.LoginPath = "/admin/login";
                options.LogoutPath = "/";
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.Cookie.Name = EmAuthenticationDefaults.AdminCookieName;
            });

            return builder;
        }

        /// <summary>
        /// Register Emeraude administration mapping configuration.
        /// </summary>
        /// <param name="configuration"></param>
        public static void AddAdminMapperConfiguration(this IMapperConfigurationExpression configuration)
        {
            configuration.AddMaps("Definux.Emeraude.Admin");
            configuration.AddMaps("Definux.Emeraude.Admin.UI");
            configuration.AddMaps("Definux.Emeraude.ClientBuilder");
        }

        private static void RegisterAdapters(this IServiceCollection services, EmAdminOptions options)
        {
            services.AddScoped(typeof(IAdminMenusBuilder), options.AdminMenusBuilderType);
        }

        private static void RegisterAdminUIStore(this IServiceCollection services)
        {
            services.RegisterAsScopedAllContractedTypes(
                new List<Type> { typeof(IStoreModule) },
                new List<Assembly> { AdminUIAssemblyPart.Assembly });
        }
    }
}
