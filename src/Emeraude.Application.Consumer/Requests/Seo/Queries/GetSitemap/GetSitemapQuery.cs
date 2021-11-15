using System.Threading;
using System.Threading.Tasks;
using Definux.Utilities.Extensions;
using Emeraude.Application.Consumer.Adapters;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Application.Consumer.Requests.Seo.Queries.GetSitemap
{
    /// <summary>
    /// Query for getting sitemap of the application.
    /// </summary>
    public class GetSitemapQuery : IRequest<SitemapResult>
    {
        /// <inheritdoc/>
        public class GetSitemapQueryHandler : IRequestHandler<GetSitemapQuery, SitemapResult>
        {
            private readonly ISitemapComposition sitemapComposition;
            private readonly IHttpContextAccessor httpContextAccessor;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetSitemapQueryHandler"/> class.
            /// </summary>
            /// <param name="sitemapComposition"></param>
            /// <param name="httpContextAccessor"></param>
            public GetSitemapQueryHandler(
                ISitemapComposition sitemapComposition,
                IHttpContextAccessor httpContextAccessor)
            {
                this.sitemapComposition = sitemapComposition;
                this.httpContextAccessor = httpContextAccessor;
            }

            /// <inheritdoc/>
            public async Task<SitemapResult> Handle(GetSitemapQuery request, CancellationToken cancellationToken)
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
}