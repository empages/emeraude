﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataCreate;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDelete;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDetails;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataEdit;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataRawModel;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Schema.FormView;
using Emeraude.Application.Admin.EmPages.Services;
using Emeraude.Essentials.Extensions;
using Emeraude.Essentials.Models;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Application.Admin.EmPages.Extensions;

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
        var assembliesList = assemblies.ToList();

        services.RegisterEmPageSchemas(assembliesList);
        services.RegisterEmPagesDataServices(assembliesList);

        services.AddSingleton<IEmPageSchemaFactory, EmPageSchemaFactory>();
        services.AddScoped<IEmPageManager, EmPageManager>();
        services.AddScoped<IEmPageService, EmPageService>();

        services.RegisterAsScopedAllContractedTypes(
            new[]
            {
                typeof(IValuePipe),
                typeof(IFormViewSelectableCustomDataSource),
            },
            assembliesList);
    }

    private static void RegisterEmPageSchemas(this IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        var schemaType = typeof(IEmPageSchema<>);

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

    private static void RegisterEmPagesDataServices(this IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        var managerTypes = new List<Type>();
        var entityDataStrategiesTypes = new List<Type>();
        var customDataStrategiesTypes = new List<Type>();

        foreach (var assembly in assemblies)
        {
            var assemblyManagerTypes = assembly
                .GetTypes()
                .Where(x => !x.IsInterface && !x.IsAbstract && x.GetInterfaces().Any(xx => xx == typeof(IEmPageDataManager)));
            managerTypes.AddRange(assemblyManagerTypes);

            var assemblyEntityDataStrategiesTypes = assembly
                .GetTypes()
                .Where(x => !x.IsInterface && !x.IsAbstract && x.GetInterfaces().Any(xx => xx == typeof(IEmPageEntityDataStrategy)));
            entityDataStrategiesTypes.AddRange(assemblyEntityDataStrategiesTypes);

            customDataStrategiesTypes.AddRange(assembly
                .GetTypes()
                .Where(x => !x.IsInterface && !x.IsAbstract && x.GetInterfaces().Any(xx => xx == typeof(IEmPageCustomDataStrategy))));
        }

        if (!managerTypes.Any())
        {
            return;
        }

        foreach (var managerType in managerTypes)
        {
            services.AddTransient(managerType);
        }

        foreach (var strategyType in entityDataStrategiesTypes)
        {
            var genericTypeArguments = strategyType.BaseType?.GetTypeInfo().GenericTypeArguments;
            if (!(genericTypeArguments?.Length > 1))
            {
                continue;
            }

            var entityType = strategyType.BaseType.GetTypeInfo().GenericTypeArguments[0];
            var modelType = strategyType.BaseType.GetTypeInfo().GenericTypeArguments[1];

            services.AddTransient(strategyType);
            services.RegisterFetchQueries(entityType, modelType);
            services.RegisterDetailsQueries(entityType, modelType);
            services.RegisterRawModelQueries(entityType, modelType);
            services.RegisterCreateCommands(entityType, modelType);
            services.RegisterEditCommands(entityType, modelType);
            services.RegisterDeleteCommands(entityType, modelType);
        }

        foreach (var customDataStrategyType in customDataStrategiesTypes)
        {
            services.AddTransient(customDataStrategyType);
        }
    }

    private static void RegisterFetchQueries(
        this IServiceCollection services,
        Type entityType,
        Type modelType)
    {
        var paginatedResultType = typeof(PaginatedList<>)
            .MakeGenericType(modelType);

        var queryType = typeof(EmPageDataFetchQuery<,>)
            .MakeGenericType(entityType, modelType);

        var queryRequestHandlerType = typeof(IRequestHandler<,>)
            .MakeGenericType(queryType, paginatedResultType);

        var queryHandler = typeof(EmPageDataFetchQueryHandler<,>)
            .MakeGenericType(entityType, modelType);

        services.AddTransient(queryRequestHandlerType, queryHandler);
    }

    private static void RegisterDetailsQueries(
        this IServiceCollection services,
        Type entityType,
        Type modelType)
    {
        var queryType = typeof(EmPageDataDetailsQuery<,>)
            .MakeGenericType(entityType, modelType);

        var queryRequestHandlerType = typeof(IRequestHandler<,>)
            .MakeGenericType(queryType, modelType);

        var queryHandler = typeof(EmPageDataDetailsQueryHandler<,>)
            .MakeGenericType(entityType, modelType);

        services.AddTransient(queryRequestHandlerType, queryHandler);
    }

    private static void RegisterRawModelQueries(
        this IServiceCollection services,
        Type entityType,
        Type modelType)
    {
        var queryType = typeof(EmPageDataRawModelQuery<,>)
            .MakeGenericType(entityType, modelType);

        var queryRequestHandlerType = typeof(IRequestHandler<,>)
            .MakeGenericType(queryType, modelType);

        var queryHandler = typeof(EmPageDataRawModelQueryHandler<,>)
            .MakeGenericType(entityType, modelType);

        services.AddTransient(queryRequestHandlerType, queryHandler);
    }

    private static void RegisterCreateCommands(
        this IServiceCollection services,
        Type entityType,
        Type modelType)
    {
        var commandType = typeof(EmPageDataCreateCommand<,>)
            .MakeGenericType(entityType, modelType);

        var commandRequestHandlerType = typeof(IRequestHandler<,>)
            .MakeGenericType(commandType, typeof(Guid?));

        var commandHandler = typeof(EmPageDataCreateCommandHandler<,>)
            .MakeGenericType(entityType, modelType);

        var commandValidatorType = typeof(EmPageDataCreateCommandValidator<,>)
            .MakeGenericType(entityType, modelType);

        var commandValidatorContractType = typeof(IValidator<>)
            .MakeGenericType(commandType);

        services.AddTransient(commandRequestHandlerType, commandHandler);
        services.AddTransient(commandValidatorContractType, commandValidatorType);
    }

    private static void RegisterEditCommands(
        this IServiceCollection services,
        Type entityType,
        Type modelType)
    {
        var commandType = typeof(EmPageDataEditCommand<,>)
            .MakeGenericType(entityType, modelType);

        var commandRequestHandlerType = typeof(IRequestHandler<,>)
            .MakeGenericType(commandType, typeof(Guid?));

        var commandHandler = typeof(EmPageDataEditCommandHandler<,>)
            .MakeGenericType(entityType, modelType);

        var commandValidatorType = typeof(EmPageDataEditCommandValidator<,>)
            .MakeGenericType(entityType, modelType);

        var commandValidatorContractType = typeof(IValidator<>)
            .MakeGenericType(commandType);

        services.AddTransient(commandRequestHandlerType, commandHandler);
        services.AddTransient(commandValidatorContractType, commandValidatorType);
    }

    private static void RegisterDeleteCommands(
        this IServiceCollection services,
        Type entityType,
        Type modelType)
    {
        var commandType = typeof(EmPageDataDeleteCommand<,>)
            .MakeGenericType(entityType, modelType);

        var commandRequestHandlerType = typeof(IRequestHandler<,>)
            .MakeGenericType(commandType, typeof(bool));

        var commandHandler = typeof(EmPageDataDeleteCommandHandler<,>)
            .MakeGenericType(entityType, modelType);

        services.AddTransient(commandRequestHandlerType, commandHandler);
    }
}