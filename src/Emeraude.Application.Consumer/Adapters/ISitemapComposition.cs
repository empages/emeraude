using System.Collections.Generic;
using System.Threading.Tasks;
using Emeraude.Application.Consumer.Models;

namespace Emeraude.Application.Consumer.Adapters
{
    /// <summary>
    /// Contract for setup all <see cref="PageSitemapPattern"/>.
    /// </summary>
    public interface ISitemapComposition
    {
        /// <summary>
        /// Setup method for defining all sitemap patterns.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PageSitemapPattern>> SetupAsync();
    }
}