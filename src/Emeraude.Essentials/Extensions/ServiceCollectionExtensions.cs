using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Emeraude.Essentials.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Register all types that implements specified contract in the selected assemblies.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="contracts"></param>
    /// <param name="assemblies"></param>
    public static void RegisterAsTransientAllContractedTypes(
        this IServiceCollection services,
        IEnumerable<Type> contracts,
        IEnumerable<Assembly> assemblies)
    {
        var typesForRegistration = FetchAllContractedTypes(contracts, assemblies);
        foreach (var type in typesForRegistration)
        {
            services.AddTransient(type);
        }
    }

    /// <summary>
    /// Register all types that implements specified contract in the selected assemblies.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="contracts"></param>
    /// <param name="assemblies"></param>
    public static void RegisterAsScopedAllContractedTypes(
        this IServiceCollection services,
        IEnumerable<Type> contracts,
        IEnumerable<Assembly> assemblies)
    {
        var typesForRegistration = FetchAllContractedTypes(contracts, assemblies);
        foreach (var type in typesForRegistration)
        {
            services.AddScoped(type);
        }
    }

    /// <summary>
    /// Load options from appsettings.json.
    /// </summary>
    /// <typeparam name="TOptions">Option object that implement the option configuration.</typeparam>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <param name="sectionName">Name of the section where are defined the options.</param>
    public static void LoadOptions<TOptions>(
        this IServiceCollection services,
        IConfiguration configuration,
        string sectionName)
        where TOptions : class
    {
        services.Configure<TOptions>(configuration.GetSection(sectionName));
    }

    /// <summary>
    /// Get loaded options from appsettings.json.
    /// </summary>
    /// <typeparam name="TOptions">Option object that implement the option configuration.</typeparam>
    /// <param name="services"></param>
    /// <returns></returns>
    public static TOptions GetOptions<TOptions>(this IServiceCollection services)
        where TOptions : class, new()
    {
        var serviceProvider = services.BuildServiceProvider();
        var options = serviceProvider.GetService<IOptions<TOptions>>();

        return options?.Value;
    }

    private static IEnumerable<Type> FetchAllContractedTypes(
        IEnumerable<Type> contracts,
        IEnumerable<Assembly> assemblies)
    {
        var typesForRegistration = new List<Type>();
        foreach (var assembly in assemblies)
        {
            typesForRegistration.AddRange(assembly
                .GetTypes()
                .Where(x => x.GetInterfaces().Any(contracts.Contains))
                .ToList());
        }

        return typesForRegistration;
    }
}