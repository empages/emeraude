using System;
using Definux.Emeraude.Tests.Project;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Definux.Emeraude.Tests.Base
{
    public class TestServiceProvider : IDisposable
    {
        private readonly TestServer testServer;

        private TestServiceProvider()
        {
            var hostBuilder = new WebHostBuilder()
                .UseEnvironment("Testing")
                .UseStartup<Startup>();
            this.testServer = new TestServer(hostBuilder);
        }

        public static TestServiceProvider GetInstance() => Instance ??= new TestServiceProvider();

        public TService GetService<TService>()
        {
            return (TService)this.testServer.Services.GetService(typeof(TService));
        }

        public void Dispose()
        {
            this.testServer.Dispose();
        }

        private static TestServiceProvider Instance { get; set; }
    }
}