using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Client.Models;

namespace Definux.Emeraude.Client.Adapters
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