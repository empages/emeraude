using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Definux.Emeraude.Client.Requests.Seo.Queries.GetSitemap;
using Definux.Emeraude.Tests.Base;
using FluentAssertions;
using Xunit;

namespace Definux.Emeraude.Tests.Client.Integration
{
    public class ClientSeoControllerTests : ClientIntegrationTest
    {
        public ClientSeoControllerTests(EmeraudeWebApplicationFactory factory)
            : base(factory)
        {
        }
        
        [Fact]
        public async Task Sitemap_OnCorrectSetup_ShouldReturnCorrectSitemap()
        {
            var requestBuilder = this.Factory.Server.CreateRequest("/sitemap.xml");
            var responseMessage = await requestBuilder.GetAsync();
            var rawSitemap = await responseMessage.Content.ReadAsStringAsync();
            MemoryStream sitemapStream = new MemoryStream(Encoding.UTF8.GetBytes(rawSitemap));
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SitemapResult));
            var sitemapResult = xmlSerializer.Deserialize(sitemapStream) as SitemapResult;

            sitemapResult
                .Should()
                .NotBeNull();
            
            sitemapResult
                .Urls
                .Should()
                .HaveCount(1);
            
            sitemapResult
                .Urls
                .Select(x => new
                {
                    x.Priority,
                    x.ChangeFrequency,
                    x.Location
                })
                .First()
                .Should()
                .BeEquivalentTo(new
                {
                    Priority = "0.5",
                    ChangeFrequency = "Yearly",
                    Location = "http://localhost/test"
                });
        }

        [Fact]
        public async Task Robots_OnCorrectSetup_ShouldReturnCorrectContent()
        {
            var requestBuilder = this.Factory.Server.CreateRequest("/robots.txt");
            var responseMessage = await requestBuilder.GetAsync();
            var robotsTxtContent = await responseMessage.Content.ReadAsStringAsync();

            robotsTxtContent
                .Should()
                .Be("User-agent: *");
        }
    }
}