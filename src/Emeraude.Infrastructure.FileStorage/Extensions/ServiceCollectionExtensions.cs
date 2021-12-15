using Emeraude.Infrastructure.FileStorage.Options;
using Emeraude.Infrastructure.FileStorage.Services;
using Emeraude.Infrastructure.FileStorage.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Infrastructure.FileStorage.Extensions;

/// <summary>
/// Extensions for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers system file management services.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static IServiceCollection RegisterEmeraudeSystemFilesManagement(
        this IServiceCollection services,
        EmFilesOptions options)
    {
        services.AddSingleton<ITemporaryFilesService, TemporaryFilesService>();
        services.AddSingleton<IFoldersInitializer, FoldersInitializer>();
        services.AddScoped<ISystemFilesService, SystemFilesService>();
        services.AddScoped<IFilesValidationProvider, FilesValidationProvider>();
        services.AddScoped<IUploadService, UploadService>();
        services.AddScoped<IRootsService, RootsService>();

        return services;
    }
}