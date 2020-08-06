using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Files.Services;
using Definux.Emeraude.Files.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Files.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterEmeraudeSystemFilesManagement(this IServiceCollection services)
        {
            services.AddScoped<ISystemFilesService, SystemFilesService>();
            services.AddScoped<IFilesValidationProvider, FilesValidationProvider>();

            return services;
        }
    }
}
