using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Definux.Emeraude.Admin.Adapters;
using Definux.Emeraude.Admin.EmPages.Extensions;
using Definux.Emeraude.Admin.Requests.ApplyImage;
using Definux.Emeraude.Admin.Requests.GetEntityImage;
using Definux.Emeraude.Admin.UI;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.Admin.UI.Store;
using Definux.Emeraude.ClientBuilder.UI.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Extensions;
using Definux.Emeraude.Persistence;
using MediatR;
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

            services.ConfigureAdminClientBuilderUI();

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
            builder.AddCookie(AuthenticationDefaults.AdminAuthenticationScheme, options =>
            {
                options.LoginPath = "/admin/login";
                options.LogoutPath = "/";
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.Cookie.Name = AuthenticationDefaults.AdminCookieName;
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

        private static void RegisterEntityImageGenericRequests(
            this IServiceCollection services,
            Type entityType,
            Type viewModelType)
        {
            if (entityType.GetInterfaces().Any(x => x == typeof(IEntityWithImage)))
            {
                Type requestHandlerType = typeof(IRequestHandler<,>);
                Type applyImageCommandType = typeof(ApplyImageCommand<>);
                Type applyImageCommandHandlerType = typeof(ApplyImageCommandHandler<>);
                Type getEntityImageQueryType = typeof(GetEntityImageQuery<>);
                Type getEntityImageQueryHandlerType = typeof(GetEntityImageQueryHandler<>);

                // Register ApplyImageCommand
                Type constructedApplyImageCommandType = applyImageCommandType.MakeGenericType(entityType);
                Type constructedApplyImageCommandRequestHandlerType = requestHandlerType.MakeGenericType(constructedApplyImageCommandType, typeof(bool));
                Type constructedApplyImageCommandHandler = applyImageCommandHandlerType.MakeGenericType(entityType);
                services.AddTransient(constructedApplyImageCommandRequestHandlerType, constructedApplyImageCommandHandler);

                // Register ExistsQuery
                Type constructedGetEntityImageQueryType = getEntityImageQueryType.MakeGenericType(entityType);
                Type constructedGetEntityImageQueryRequestHandlerType = requestHandlerType.MakeGenericType(constructedGetEntityImageQueryType, typeof(string));
                Type constructedGetEntityImageQueryHandler = getEntityImageQueryHandlerType.MakeGenericType(entityType);
                services.AddTransient(constructedGetEntityImageQueryRequestHandlerType, constructedGetEntityImageQueryHandler);
            }
        }

        private static void RegisterAdapters(this IServiceCollection services, EmAdminOptions options)
        {
            services.AddScoped<IIdentityUserInfoAdapter, IdentityUserInfoAdapter>();
            services.AddScoped<IEmContextAdapter, EmContextAdapter>();

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
