using Emeraude.Pages.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Emeraude.Pages.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds Emeraude pages services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddEmeraudePages(this IServiceCollection services, IEmPagesOptions options)
    {
        services.TryAddSingleton<IEmServiceFactory, ServiceFactory>();
        services.TryAddSingleton<IEmPageStore, PageStore>();
        services.TryAddSingleton<IEmMappingStrategy, TableMappingStrategy>();
        services.TryAddSingleton<IEmMappingStrategy, DetailsMappingStrategy>();
        services.TryAddSingleton<IEmMappingStrategy, FormMappingStrategy>();
        services.TryAddSingleton<IEmPageMapper, PageMapper>();
        services.TryAddSingleton<IEmRouter, Router>();

        return services;
    }
}