using Emeraude.Application.Admin.Adapters;
using Emeraude.Application.Admin.Options;
using Emeraude.Configuration.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Application.Admin.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Register all required Emeraude administration services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="adminOptions"></param>
    /// <param name="mainOptions"></param>
    public static void AddEmeraudeAdmin(
        this IServiceCollection services,
        EmAdminOptions adminOptions,
        EmMainOptions mainOptions)
    {
        services.AddRouting();

        services.RegisterAdapters(adminOptions);
    }

    private static void RegisterAdapters(this IServiceCollection services, EmAdminOptions options)
    {
        services.AddScoped(typeof(IAdminMenusBuilder), options.AdminMenusBuilderType);
    }
}