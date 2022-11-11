using System.Collections.Generic;
using System.Linq;
using EmPages.Pages.Services;
using Essentials.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EmPages.Pages.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds EmPages pages services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddEmeraudePages(this IServiceCollection services, IEmPagesOptions options)
    {
        services.TryAddSingleton<IEmServiceFactory, ServiceFactory>();
        services.TryAddSingleton<IEmPageStore, EmPageStore>();
        services.TryAddSingleton<IEmMappingStrategy, TableMappingStrategy>();
        services.TryAddSingleton<IEmMappingStrategy, DetailsMappingStrategy>();
        services.TryAddSingleton<IEmMappingStrategy, FormMappingStrategy>();
        services.TryAddSingleton<IEmPageMapper, PageMapper>();
        services.TryAddSingleton<IEmRouter, EmRouter>();

        services.RegisterAssembliesPages(options);

        return services;
    }

    private static void RegisterAssembliesPages(this IServiceCollection services, IEmPagesOptions options)
    {
        foreach (var assembly in options.PagesAssemblies)
        {
            var assemblyPages = assembly.GetTypes().Where(x => x.HasInterface<IEmPage>() && !x.IsAbstract);
            foreach (var page in assemblyPages)
            {
                services.TryAddScoped(page);
            }
        }
    }
}