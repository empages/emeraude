using System;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

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
                    var options = services.GetRequiredService<IOptions<EmMainOptions>>().Value;

                    databaseInitializerManager.LoadDatabaseInitializers(options.DatabaseInitializers);
                    databaseInitializerManager.SeedAsync().Wait();
                    foldersInitializer.InitFoldersAsync().Wait();
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
