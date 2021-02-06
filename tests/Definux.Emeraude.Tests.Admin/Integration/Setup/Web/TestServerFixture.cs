using System;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Web
{
    public class TestServerFixture : IDisposable
    {
        public TestServer TestServer { get; set; }

        public TestServerFixture()
        {
            var hostBuilder = new WebHostBuilder()
                .UseEnvironment("Testing")
                .UseStartup<Startup>();
            TestServer = new TestServer(hostBuilder);

            try
            {
                var databaseInitializerManager =
                    TestServer?.Host?.Services?.GetService(typeof(IDatabaseInitializerManager)) as
                        IDatabaseInitializerManager;
                databaseInitializerManager.LoadDatabaseInitializers(new Type[]
                {
                    typeof(IApplicationDatabaseInitializer),
                    typeof(ITestDataInitializer)
                });

                databaseInitializerManager.SeedAsync().Wait();
            }
            catch (Exception e)
            {
            }
        }

        public void Dispose()
        {
            TestServer.Dispose();
        }
    }
}