using System.Threading.Tasks;
using Definux.Emeraude.Application.Consumer.Requests.Seo.Queries.GetSitemap;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Presentation.PlatformBase.Controllers
{
    /// <summary>
    /// Abstract controller that builds XML sitemap endpoint.
    /// </summary>
    public abstract class SitemapController : EmController
    {
        /// <summary>
        /// Action of the sitemap.xml file.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/sitemap.xml")]
        [Produces("application/xml")]
        public virtual async Task<IActionResult> Sitemap() => this.Ok(await this.Mediator.Send(new GetSitemapQuery()));
    }
}