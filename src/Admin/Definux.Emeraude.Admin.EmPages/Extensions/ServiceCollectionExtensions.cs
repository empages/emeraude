using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Definux.Emeraude.Admin.EmPages.Data;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDelete;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataEdit;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataExists;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.Services;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Essentials.Extensions;
using Definux.Emeraude.Essentials.Models;
using Definux.Emeraude.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Admin.EmPages.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register EmPages.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="assemblies"></param>
        public static void RegisterEmPages(this IServiceCollection services, IEnumerable<Assembly> assemblies)
        {
            services.RegisterEmPageSchemas(assemblies);
            services.RegisterEmPagesRequests(assemblies);

            services.AddScoped<IEmPageSchemaProvider, EmPageSchemaProvider>();
            services.AddScoped<IEmPageDataProvider, EmPageDataProvider>();
            services.AddScoped<IEmPageService, EmPageService>();

            services.RegisterAsScopedAllContractedTypes(
                new[]
                {
                    typeof(IValuePipe),
                },
                assemblies);
        }

        private static void RegisterEmPageSchemas(this IServiceCollection services, IEnumerable<Assembly> assemblies)
        {
            var schemaType = typeof(IEmPageSchema<,>);

            var schemasImplementationsTypes = assemblies
                .SelectMany(x => x
                    .GetExportedTypes()
                    .Where(y => y.IsClass && y.GetInterfaces()
                        .Any(z => z.IsGenericType && z.GetGenericTypeDefinition() == schemaType))
                    .ToList())
                .ToList();

            foreach (var schemasImplementationType in schemasImplementationsTypes)
            {
                services.AddScoped(schemasImplementationType);
            }
        }

        private static void RegisterEmPagesRequests(this IServiceCollection services, IEnumerable<Assembly> assemblies)
        {
            var managerTypes = new List<Type>();

            foreach (var assembly in assemblies)
            {
                var assemblyManagerTypes = assembly
                    .GetTypes()
                    .Where(x => x
                        .GetInterfaces()
                        .Any(xx => xx == typeof(IEmPageDataManager)) && !x.IsInterface && !x.IsAbstract);
                managerTypes.AddRange(assemblyManagerTypes);
            }

            if (!managerTypes.Any())
            {
                return;
            }

            foreach (var managerType in managerTypes)
            {
                var genericTypeArguments = managerType.BaseType?.GetTypeInfo().GenericTypeArguments;
                if (!(genericTypeArguments?.Length > 1))
                {
                    continue;
                }

                var entityType = managerType.BaseType.GetTypeInfo().GenericTypeArguments[0];
                var modelType = managerType.BaseType.GetTypeInfo().GenericTypeArguments[1];

                services.AddTransient(managerType);
                services.RegisterFetchGenericQueries(entityType, modelType);
                services.RegisterDetailsGenericQueries(entityType, modelType);
                services.RegisterExistsGenericQueries(entityType);
                services.RegisterCreateGenericCommands(entityType, modelType);
                services.RegisterEditGenericCommands(entityType, modelType);
                services.RegisterDeleteGenericCommands(entityType);
            }
        }

        private static void RegisterFetchGenericQueries(
            this IServiceCollection services,
            Type entityType,
            Type modelType)
        {
            Type paginatedResultType = typeof(PaginatedList<>);
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type queryType = typeof(EmPageDataFetchQuery<,>);
            Type queryHandler = typeof(EmPageDataFetchQueryHandler<,>);
            Type constructedPaginatedResultType = paginatedResultType.MakeGenericType(modelType);
            Type constructedQueryType = queryType.MakeGenericType(entityType, modelType);
            Type constructedQueryRequestHandlerType = requestHandlerType.MakeGenericType(constructedQueryType, constructedPaginatedResultType);
            Type constructedQueryHandler = queryHandler.MakeGenericType(entityType, modelType);

            services.AddTransient(constructedQueryRequestHandlerType, constructedQueryHandler);
        }

        private static void RegisterDetailsGenericQueries(
            this IServiceCollection services,
            Type entityType,
            Type modelType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type queryType = typeof(EmPageDataDetailsQuery<,>);
            Type queryHandlerType = typeof(EmPageDataDetailsQueryHandler<,>);
            Type constructedQueryType = queryType.MakeGenericType(entityType, modelType);
            Type constructedQueryRequestHandlerType = requestHandlerType.MakeGenericType(constructedQueryType, modelType);
            Type constructedQueryHandler = queryHandlerType.MakeGenericType(entityType, modelType);
            services.AddTransient(constructedQueryRequestHandlerType, constructedQueryHandler);
        }

        private static void RegisterExistsGenericQueries(
            this IServiceCollection services,
            Type entityType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type queryType = typeof(EmPageDataExistsQuery<>);
            Type queryHandlerType = typeof(EmPageDataExistsQueryHandler<>);
            Type constructedQueryType = queryType.MakeGenericType(entityType);
            Type constructedQueryRequestHandlerType = requestHandlerType.MakeGenericType(constructedQueryType, typeof(bool));
            Type constructedQueryHandler = queryHandlerType.MakeGenericType(entityType);
            services.AddTransient(constructedQueryRequestHandlerType, constructedQueryHandler);
        }

        private static void RegisterCreateGenericCommands(
            this IServiceCollection services,
            Type entityType,
            Type modelType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type commandType = typeof(EmPageDataCreateCommand<,>);
            Type commandHandlerType = typeof(EmPageDataCreateCommandHandler<,>);
            Type constructedCommandType = commandType.MakeGenericType(entityType, modelType);
            Type constructedCommandRequestHandlerType = requestHandlerType.MakeGenericType(constructedCommandType, typeof(Guid?));
            Type constructedCommandHandler = commandHandlerType.MakeGenericType(entityType, modelType);
            services.AddTransient(constructedCommandRequestHandlerType, constructedCommandHandler);
        }

        private static void RegisterEditGenericCommands(
            this IServiceCollection services,
            Type entityType,
            Type modelType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type commandType = typeof(EmPageDataEditCommand<,>);
            Type commandHandlerType = typeof(EmPageDataEditCommandHandler<,>);
            Type constructedCommandType = commandType.MakeGenericType(entityType, modelType);
            Type constructedCommandRequestHandlerType = requestHandlerType.MakeGenericType(constructedCommandType, typeof(Guid?));
            Type constructedCommandHandler = commandHandlerType.MakeGenericType(entityType, modelType);
            services.AddTransient(constructedCommandRequestHandlerType, constructedCommandHandler);
        }

        private static void RegisterDeleteGenericCommands(
            this IServiceCollection services,
            Type entityType)
        {
            Type requestHandlerType = typeof(IRequestHandler<,>);
            Type commandType = typeof(EmPageDataDeleteCommand<>);
            Type commandHandlerType = typeof(EmPageDataDeleteCommandHandler<>);
            Type constructedCommandType = commandType.MakeGenericType(entityType);
            Type constructedCommandRequestHandlerType = requestHandlerType.MakeGenericType(constructedCommandType, typeof(bool));
            Type constructedCommandHandler = commandHandlerType.MakeGenericType(entityType);
            services.AddTransient(constructedCommandRequestHandlerType, constructedCommandHandler);
        }
    }
}