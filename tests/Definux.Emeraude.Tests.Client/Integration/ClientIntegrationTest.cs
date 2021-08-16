using System.Net.Http;
using Definux.Emeraude.Tests.Base;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Definux.Emeraude.Tests.Client.Integration
{
    public class ClientIntegrationTest : IClassFixture<EmeraudeWebApplicationFactory>
    {
        public ClientIntegrationTest(EmeraudeWebApplicationFactory factory)
        {
            this.Factory = factory;
            this.HttpClient = this.Factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                HandleCookies = true,
                AllowAutoRedirect = true
            });
        }

        protected HttpClient HttpClient { get; }

        protected EmeraudeWebApplicationFactory Factory { get; }
    }
}