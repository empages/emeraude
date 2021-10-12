using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Persistence.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude
{
    /// <summary>
    /// Emeraude program base class used for initial point of the application.
    /// </summary>
    public class EmProgram
    {
        /// <summary>
        /// The main method of application which must be called by the Main method of the application.
        /// </summary>
        /// <param name="hostBuilder"></param>
        /// <param name="initialFunction"></param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        protected static async Task RunEmeraudeAsync(IHostBuilder hostBuilder, Func<IServiceProvider, Task> initialFunction = null)
        {
            var host = hostBuilder.Build();
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var databaseInitializerManager = services.GetRequiredService<IDatabaseInitializerManager>();
                var foldersInitializer = services.GetRequiredService<IFoldersInitializer>();
                var optionsProvider = services.GetRequiredService<IEmOptionsProvider>();
                var languagesResourceManager = services.GetRequiredService<ILanguagesResourceManager>();

                databaseInitializerManager
                    .LoadDatabaseInitializers(
                        optionsProvider
                            .GetPersistenceOptions()
                            .DatabaseInitializers);

                await databaseInitializerManager.SeedAsync();
                foldersInitializer.InitFolders();
                languagesResourceManager.BuildResources();

                if (initialFunction != null)
                {
                    await initialFunction(services);
                }
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<EmProgram>>();
                logger.LogError(ex, "An unexpected error occured during application startup");
            }

            await host.RunAsync();
        }
    }
}
