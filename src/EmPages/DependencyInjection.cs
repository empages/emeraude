using System;
using System.Threading.Tasks;
using EmPages.Application;
using EmPages.Application.Common;
using EmPages.Identity;
using EmPages.Pages;
using EmPages.Pages.Components.Mutators;
using EmPages.Pages.Components.Renderers;
using EmPages.Portal;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmPages;

/// <summary>
/// Main EmPages Framework dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    private static readonly Action<EmOptions> DefaultOptionsAction =
        options =>
        {
            options.AddPagesAssembly(ApplicationAssembly.Assembly);
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
        services.AddSingleton<IEmPortalOptions>(x => x.GetRequiredService<EmOptions>());

        services.AddHttpContextAccessor();

        services.AddPages(options);
        services.AddIdentity(options);
        services.AddPortal(options);

        return services;
    }

    /// <summary>
    /// Starts EmPages Framework into current web application.
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static async Task StartEmeraudeAsync(this WebApplication app)
    {
        try
        {
            using var scope = app.Services.CreateScope();
            var serviceProvider = scope.ServiceProvider;
            var pageStore = serviceProvider.GetRequiredService<IEmPageStore>();
            var identityInitializer = serviceProvider.GetRequiredService<IEmIdentityInitializer>();

            await pageStore.InitializeAsync();
            await identityInitializer.InitializeAsync();
        }
        catch (Exception ex)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
#pragma warning disable CA2254
            app.Logger.LogError(ex.Message);
#pragma warning restore CA2254
        }
    }
}