using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Tests.Project;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Tests.Abstractions
{
    public class EmeraudeWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            var hostBuilder = new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>()
                .UseTestServer();
            
            return hostBuilder;
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            base.ConfigureWebHost(builder);

            builder.ConfigureServices(services =>
            {
                using (var serviceProvider = services.BuildServiceProvider())
                {
                    var databaseInitializerManager = serviceProvider.GetService<IDatabaseInitializerManager>();
                    databaseInitializerManager.LoadDatabaseInitializers(new []
                    {
                        typeof(IApplicationDatabaseInitializer)
                    });

                    databaseInitializerManager.SeedAsync().Wait();
                }
            });
        }
    }
}