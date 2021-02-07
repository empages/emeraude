using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Definux.Emeraude.Tests.Abstractions
{
    public abstract class IntegrationTest : IClassFixture<EmeraudeWebApplicationFactory>
    {
        private readonly EmeraudeWebApplicationFactory factory;
        
        public IntegrationTest(EmeraudeWebApplicationFactory factory)
        {
            this.factory = factory;
            HttpClient = this.factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                HandleCookies = true,
                AllowAutoRedirect = true
            });
        }

        public HttpClient HttpClient { get; }

        protected async Task<AntiForgeryTokenMeta> GetAntiForgeryTokenMetaFromPageAsync(string relativeUrl)
        {
            var result = new AntiForgeryTokenMeta();
            
            var initResponse = await this.HttpClient.GetAsync(relativeUrl);
            initResponse.Headers.TryGetValues("Set-Cookie", out var cookies);

            var antiForgeryTokenKeyValue = cookies
                .First(x => x.StartsWith(".AspNetCore.Antiforgery."))
                .Split(";")
                .First()
                .Split("=");

            result.CookieName = antiForgeryTokenKeyValue.First();
            result.CookieValue = antiForgeryTokenKeyValue.Last();

            result.InputName = "__RequestVerificationToken";
            var responseHtml = await initResponse.Content.ReadAsStringAsync();

            HtmlDocument loginPageDocument = new HtmlDocument();
            loginPageDocument.LoadHtml(responseHtml);
            result.InputValue = loginPageDocument
                .DocumentNode
                .SelectSingleNode($"//input[@name='{result.InputName}']")
                .Attributes["value"]
                .Value;

            return result;
        }
    }
}