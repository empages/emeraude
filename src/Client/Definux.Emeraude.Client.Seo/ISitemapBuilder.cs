using System.Threading.Tasks;
using Definux.Emeraude.Client.Seo.Results;

namespace Definux.Emeraude.Client.Seo
{
    /// <summary>
    /// Service that process and build sitemap of the application.
    /// </summary>
    public interface ISitemapBuilder
    {
        /// <summary>
        /// Builds sitemap based on applied sitemap patterns.
        /// </summary>
        /// <returns></returns>
        Task<SitemapResult> BuildSitemapAsync();
    }
}
