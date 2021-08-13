using System.Threading.Tasks;
using Definux.Emeraude.Client.Requests.Seo.Queries.GetRobots;
using Definux.Emeraude.Client.Requests.Seo.Queries.GetSitemap;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <summary>
    /// Main controller of SEO endpoints.
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    public sealed class ClientSeoController : ClientController
    {
        /// <summary>
        /// Action of the robots.txt file.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("text/plain")]
        [Route("/robots.txt")]
        public async Task<IActionResult> Robots() => this.Content(await this.Mediator.Send(new GetRobotsQuery()));

        /// <summary>
        /// Action of the sitemap.xml file.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/xml")]
        [Route("/sitemap.xml")]
        public async Task<IActionResult> Sitemap() => this.Ok(await this.Mediator.Send(new GetSitemapQuery()));
    }
}
