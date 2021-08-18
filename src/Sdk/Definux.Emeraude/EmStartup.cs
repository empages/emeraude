using System;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Persistence.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude
{
    /// <summary>
    /// Emeraude startup base class used for initial point of the application.
    /// </summary>
    public class EmStartup
    {
        /// <summary>
        /// The main method of application which must be called by the Main method of the application.
        /// </summary>
        /// <param name="hostBuilder"></param>
        public static void RunEmeraude(IHostBuilder hostBuilder)
        {
            var host = hostBuilder.Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var databaseInitializerManager = services.GetRequiredService<IDatabaseInitializerManager>();
                    var foldersInitializer = services.GetRequiredService<IFoldersInitializer>();
                    var optionsProvider = services.GetRequiredService<IEmOptionsProvider>();
                    var languagesResourceManager = services.GetRequiredService<ILanguagesResourceManager>();

                    databaseInitializerManager.LoadDatabaseInitializers(optionsProvider.GetPersistenceOptions().DatabaseInitializers);
                    databaseInitializerManager.SeedAsync().Wait();
                    foldersInitializer.InitFoldersAsync().Wait();
                    languagesResourceManager.BuildResources();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                host.Run();
            }
        }
    }
}
