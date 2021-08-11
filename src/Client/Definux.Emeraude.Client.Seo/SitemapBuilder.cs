using System.Threading.Tasks;
using Definux.Emeraude.Client.Seo.Results;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Client.Seo
{
    /// <inheritdoc cref="ISitemapBuilder"/>
    public sealed class SitemapBuilder : ISitemapBuilder
    {
        private readonly ISitemapComposition sitemapComposition;
        private readonly IHttpContextAccessor httpContextAccessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapBuilder"/> class.
        /// </summary>
        /// <param name="sitemapComposition"></param>
        /// <param name="httpContextAccessor"></param>
        public SitemapBuilder(
            ISitemapComposition sitemapComposition,
            IHttpContextAccessor httpContextAccessor)
        {
            this.sitemapComposition = sitemapComposition;
            this.httpContextAccessor = httpContextAccessor;
        }

        /// <inheritdoc/>
        public async Task<SitemapResult> BuildSitemapAsync()
        {
            var baseUrl = this.httpContextAccessor.HttpContext.GetAbsoluteRoute(string.Empty);
            var sitemapPatterns = await this.sitemapComposition.SetupAsync();
            var result = new SitemapResult();
            foreach (var pattern in sitemapPatterns)
            {
                pattern.SetBaseUrl(baseUrl);
                result.Urls.AddRange(await pattern.BuildPatternUrlsAsync());
            }

            return result;
        }
    }
}
