using System;
using Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmDoggoDev
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("PACKAGE_VERSION", "0.0.0.0");

            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    // Get instance of database initializer
                    var databaseInitializerManager = services.GetRequiredService<IDatabaseInitializerManager>();

                    databaseInitializerManager
                        .LoadDatabaseInitializers(
                            typeof(IApplicationDatabaseInitializer) // Loads main data seeder
                        );

                    databaseInitializerManager.SeedAsync().Wait();
                }
                catch (Exception) { }

                host.Run();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // Uncomment the line below if you want to use kestrel instead of IIS
                    // webBuilder.UseKestrel();

                    webBuilder.UseStaticWebAssets();
                    webBuilder.UseStartup<Startup>();
                });
    }
}
