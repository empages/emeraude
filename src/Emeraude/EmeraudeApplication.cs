using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Emeraude.Configuration.Options;
using Emeraude.Infrastructure.FileStorage.Services;
using Emeraude.Infrastructure.Localization.Services;
using Emeraude.Infrastructure.Persistence.Extensions;
using Emeraude.Infrastructure.Persistence.Seed;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebMarkupMin.AspNetCore3;

namespace Emeraude
{
    /// <summary>
    /// Emeraude initial class used for start the web application.
    /// </summary>
    public static class EmeraudeApplication
    {
        /// <summary>
        /// The main method of application which must be called by the Main method of the application.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="builderAction"></param>
        /// <param name="appAction"></param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task RunAsync(
            string[] args,
            Action<WebApplicationBuilder> builderAction = null,
            Action<WebApplication> appAction = null)
        {
            var appBuilder = WebApplication.CreateBuilder(new WebApplicationOptions
            {
                ContentRootPath = Path.GetFullPath(Directory.GetCurrentDirectory()),
                WebRootPath = "wwwroot",
                Args = args,
            });

            builderAction?.Invoke(appBuilder);

            var app = appBuilder.Build();
            appAction?.Invoke(app);

            app.MapControllers();
            app.MapDefaultControllerRoute();

            try
            {
                var databaseInitializerManager = app.Services.GetService<IDatabaseInitializerManager>();
                var foldersInitializer = app.Services.GetService<IFoldersInitializer>();
                var optionsProvider = app.Services.GetService<IEmOptionsProvider>();
                var languagesResourceManager = app
                    .Services
                    .CreateScope()
                    .ServiceProvider
                    .GetService<ILanguagesResourceManager>();

                if (databaseInitializerManager != null)
                {
                    databaseInitializerManager
                        .LoadDatabaseInitializers(
                            optionsProvider
                                .GetPersistenceOptions()
                                .DatabaseInitializers);
                    await databaseInitializerManager.SeedAsync();
                }

                foldersInitializer?.InitFolders();
                languagesResourceManager?.BuildResources();

                app.UseWebMarkupMin();
            }
            catch (Exception ex)
            {
                app.Logger.LogError(ex, "An unexpected error occured during application startup");
            }

            await app.RunAsync();
        }
    }
}
