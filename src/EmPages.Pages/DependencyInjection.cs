using System.Linq;
using EmPages.Pages.Pages.Details;
using EmPages.Pages.Pages.Form;
using EmPages.Pages.Pages.Table;
using EmPages.Pages.Services;
using Essentials.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EmPages.Pages;

/// <summary>
/// EmPages Pages dependency module injector.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds EmPages pages services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection AddPages(this IServiceCollection services, IEmPagesOptions options)
    {
        services.TryAddSingleton<IEmPageStore, EmPageStore>();
        services.TryAddSingleton<IEmPageHandler, EmPageHandler>();
        services.TryAddSingleton<IEmRouter, EmRouter>();
        services.TryAddScoped<IEmLayoutService, EmLayoutService>();

        services.AddSingleton<IEmMappingStrategy, EmTableMappingStrategy>();
        services.AddSingleton<IEmMappingStrategy, EmDetailsMappingStrategy>();
        services.AddSingleton<IEmMappingStrategy, EmFormMappingStrategy>();

        services.RegisterAssembliesPages(options);
        services.RegisterAssembliesCommands(options);

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

    private static void RegisterAssembliesCommands(this IServiceCollection services, IEmPagesOptions options)
    {
        foreach (var assembly in options.PagesAssemblies)
        {
            var assemblyCommands = assembly.GetTypes().Where(x => x.HasInterface<IEmPageCommand>() && !x.IsAbstract);
            foreach (var command in assemblyCommands)
            {
                services.TryAddScoped(command);
            }
        }
    }
}