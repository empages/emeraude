using System.Net.Http;
using Emeraude.Tests.Base;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Definux.Emeraude.Tests.Core.Integration
{
    public class IntegrationTest : IClassFixture<EmeraudeWebApplicationFactory>
    {
        public IntegrationTest(EmeraudeWebApplicationFactory factory)
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