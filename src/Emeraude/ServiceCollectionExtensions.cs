using System;
using Emeraude.Application;
using Emeraude.Application.Common;
using Emeraude.Identity;
using Emeraude.Identity.Extensions;
using Emeraude.Pages;
using Emeraude.Pages.Components.Mutators;
using Emeraude.Pages.Components.Renderers;
using Emeraude.Pages.Extensions;
using Emeraude.PortalGateway;
using Emeraude.PortalGateway.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude;

/// <summary>
/// Main Emeraude Framework dependency injection extensions.
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
    /// Adds Emeraude Framework required services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="optionsAction"></param>
    /// <returns></returns>
    public static IServiceCollection AddEmeraude(this IServiceCollection services, Action<EmOptions> optionsAction)
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