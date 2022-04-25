using System;
using System.Threading.Tasks;
using Emeraude.Identity;
using Emeraude.Pages;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Emeraude;

/// <summary>
/// Web application extensions.
/// </summary>
public static class WebApplicationExtensions
{
    /// <summary>
    /// Starts Emeraude Framework into current web application.
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