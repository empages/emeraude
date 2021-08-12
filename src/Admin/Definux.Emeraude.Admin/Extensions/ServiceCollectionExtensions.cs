using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Definux.Emeraude.Admin.Adapters;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Mapping;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.Requests.ApplyImage;
using Definux.Emeraude.Admin.Requests.Create;
using Definux.Emeraude.Admin.Requests.Delete;
using Definux.Emeraude.Admin.Requests.Details;
using Definux.Emeraude.Admin.Requests.Edit;
using Definux.Emeraude.Admin.Requests.Exists;
using Definux.Emeraude.Admin.Requests.GetAll;
using Definux.Emeraude.Admin.Requests.GetEntityImage;
using Definux.Emeraude.Admin.RouteConstraints;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.ClientBuilder.UI.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

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
        public static void AddEmeraudeAdmin(this IServiceCollection services)
        {
            services.ConfigureAdminUI();
            services.ConfigureAdminClientBuilderUI();

            services.AddRouting(options =>
            {
                options.ConstraintMap.Add(RootConstraint.RootConstraintKey, typeof(RootConstraint));
            });

            services.RegisterAdapters();

            services.AddScoped<IAdminEntityMapper, AdminEntityMapper>();
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
        /// <returns></returns>
        public static IMapperConfigurationExpression AddAdminMapperConfiguration(this IMapperConfigurationExpression configuration)
        {
            configuration.AddMaps("Definux.Emeraude.Admin");
            configuration.AddMaps("Definux.Emeraude.Admin.UI");
            configuration.AddMaps("Definux.Emeraude.ClientBuilder");

            return configuration;
        }

        /// <summary>
        /// Register Emeraude administration generic requests for all <see cref="IAdminEntityController"/>.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="assemblies"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterAdminEntityControllersRequests(this IServiceCollection services, Assembly[] assemblies)
        {
            var controllerTypes = new List<Type>();

            foreach (var assembly in assemblies)
            {
                var assemblyControllerTypes = assembly
                    .GetTypes()
                    .Where(x => x
                        .GetInterfaces()
                        .Any(x => x == typeof(IAdminEntityController)) && !x.IsInterface && !x.IsAbstract);
                controllerTypes.AddRange(assemblyControllerTypes);
            }

            foreach (Type controllerType in controllerTypes)
            {
                var genericTypeArguments = controllerType.BaseType.GetTypeInfo().GenericTypeArguments;
                if (genericTypeArguments.Count() > 1)
                {
                    Type entityType = controllerType.BaseType.GetTypeInfo().GenericTypeArguments[0];
                    Type viewModelType = controllerType.BaseType.GetTypeInfo().GenericTypeArguments[1];

                    services.RegisterGetAllGenericQueries(entityType, viewModelType);
                    services.RegisterDetailsGenericQueries(entityType, viewModelType);
                    services.RegisterExistsGenericQueries(entityType, viewModelType);
                    services.RegisterCreateGenericCommands(entityType, viewModelType);
                    services.RegisterEditGenericCommands(entityType, viewModelType);
                    services.RegisterDeleteGenericCommands(entityType, viewModelType);
                    services.RegisterEntityImageGenericRequests(entityType, viewModelType);
                }
            }

            return services;
        }

        /// <summary>
        /// Register additional requests used from built-in features.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterAdditionalAdminGenericCustomRequests(this IServiceCollection services)
        {
            services.RegisterGetAllGenericQueries(typeof(User), typeof(EntitySelectModel));

            return services;
        }

        private static IServiceCollection RegisterGetAllGenericQueries(this IServiceCollection services, Type entityType, Type viewModelType)
        {
            Type paginatedResultType = typeof(PaginatedList<>);
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type queryType = typeof(GetAllQuery<,>);
            Type queryHandler = typeof(GetAllQueryHandler<,>);
            Type constructedPaginatedResultType = paginatedResultType.MakeGenericType(viewModelType);
            Type constructedQueryType = queryType.MakeGenericType(entityType, viewModelType);
            Type constructedQueryRequestHandlerType = requestHandlerType.MakeGenericType(constructedQueryType, constructedPaginatedResultType);
            Type constructedQueryHandler = queryHandler.MakeGenericType(entityType, viewModelType);

            services.AddTransient(constructedQueryRequestHandlerType, constructedQueryHandler);

            return services;
        }

        private static IServiceCollection RegisterDetailsGenericQueries(this IServiceCollection services, Type entityType, Type viewModelType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type queryType = typeof(DetailsQuery<,>);
            Type queryHandlerType = typeof(DetailsQueryHandler<,>);
            Type constructedQueryType = queryType.MakeGenericType(entityType, viewModelType);
            Type constructedQueryRequestHandlerType = requestHandlerType.MakeGenericType(constructedQueryType, viewModelType);
            Type constructedQueryHandler = queryHandlerType.MakeGenericType(entityType, viewModelType);
            services.AddTransient(constructedQueryRequestHandlerType, constructedQueryHandler);

            return services;
        }

        private static IServiceCollection RegisterExistsGenericQueries(this IServiceCollection services, Type entityType, Type viewModelType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type queryType = typeof(ExistsQuery<>);
            Type queryHandlerType = typeof(ExistsQueryHandler<>);
            Type constructedQueryType = queryType.MakeGenericType(entityType);
            Type constructedQueryRequestHandlerType = requestHandlerType.MakeGenericType(constructedQueryType, typeof(bool));
            Type constructedQueryHandler = queryHandlerType.MakeGenericType(entityType);
            services.AddTransient(constructedQueryRequestHandlerType, constructedQueryHandler);

            return services;
        }

        private static IServiceCollection RegisterCreateGenericCommands(this IServiceCollection services, Type entityType, Type viewModelType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type commandType = typeof(CreateCommand<,>);
            Type commandHandlerType = typeof(CreateCommandHandler<,>);
            Type constructedCommandType = commandType.MakeGenericType(entityType, viewModelType);
            Type constructedCommandRequestHandlerType = requestHandlerType.MakeGenericType(constructedCommandType, typeof(Guid?));
            Type constructedCommandHandler = commandHandlerType.MakeGenericType(entityType, viewModelType);
            services.AddTransient(constructedCommandRequestHandlerType, constructedCommandHandler);

            return services;
        }

        private static IServiceCollection RegisterEditGenericCommands(this IServiceCollection services, Type entityType, Type viewModelType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type commandType = typeof(EditCommand<,>);
            Type commandHandlerType = typeof(EditCommandHandler<,>);
            Type constructedCommandType = commandType.MakeGenericType(entityType, viewModelType);
            Type constructedCommandRequestHandlerType = requestHandlerType.MakeGenericType(constructedCommandType, typeof(Guid?));
            Type constructedCommandHandler = commandHandlerType.MakeGenericType(entityType, viewModelType);
            services.AddTransient(constructedCommandRequestHandlerType, constructedCommandHandler);
            return services;
        }

        private static IServiceCollection RegisterDeleteGenericCommands(this IServiceCollection services, Type entityType, Type viewModelType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type commandType = typeof(DeleteCommand<>);
            Type commandHandlerType = typeof(DeleteCommandHandler<>);
            Type constructedCommandType = commandType.MakeGenericType(entityType);
            Type constructedCommandRequestHandlerType = requestHandlerType.MakeGenericType(constructedCommandType, typeof(bool));
            Type constructedCommandHandler = commandHandlerType.MakeGenericType(entityType);
            services.AddTransient(constructedCommandRequestHandlerType, constructedCommandHandler);
            return services;
        }

        private static IServiceCollection RegisterEntityImageGenericRequests(this IServiceCollection services, Type entityType, Type viewModelType)
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

            return services;
        }

        private static IServiceCollection RegisterAdapters(this IServiceCollection services)
        {
            services.AddScoped<IIdentityUserInfoAdapter, IdentityUserInfoAdapter>();
            services.AddScoped<IEmContextAdapter, EmContextAdapter>();

            return services;
        }
    }
}
