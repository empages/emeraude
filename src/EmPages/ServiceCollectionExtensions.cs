using System;
using EmPages.Application;
using EmPages.Application.Common;
using EmPages.Identity;
using EmPages.Identity.Extensions;
using EmPages.Pages;
using EmPages.Pages.Components.Mutators;
using EmPages.Pages.Components.Renderers;
using EmPages.Pages.Extensions;
using EmPages.PortalGateway;
using EmPages.PortalGateway.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace EmPages;

/// <summary>
/// Main EmPages Framework dependency injection extensions.
/// </summary>
public static class ServiceCollectionExtensions
{
    private static readonly Action<EmOptions> DefaultOptionsAction =
        options =>
        {
            options.AddPagesAssembly(ApplicationAssembly.Assembly);

            options.ConfigureDefaultTypeToComponentMap<string, TextRenderer, TextMutator>();
            options.ConfigureDefaultTypeToComponentMap<DateOnly, TextRenderer, DateMutator>();
        };

    /// <summary>
    /// Adds EmPages Framework required services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="optionsAction"></param>
    /// <returns></returns>
    public static IServiceCollection AddEmeraldPages(this IServiceCollection services, Action<EmOptions> optionsAction)
    {
        var options = new EmOptions();
        DefaultOptionsAction?.Invoke(options);
        optionsAction?.Invoke(options);

        services.AddSingleton<EmOptions>(options);
        services.AddSingleton<IEmIdentityOptions>(x => x.GetRequiredService<EmOptions>());
        services.AddSingleton<IEmPagesOptions>(x => x.GetRequiredService<EmOptions>());
        services.AddSingleton<IEmPortalGatewayOptions>(x => x.GetRequiredService<EmOptions>());

        services.AddEmeraudePages(options);
        services.AddEmeraudeIdentity(options);
        services.AddEmeraudePortalGateway(options);

        return services;
    }
}