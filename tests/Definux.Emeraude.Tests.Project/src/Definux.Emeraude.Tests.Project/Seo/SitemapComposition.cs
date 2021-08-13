using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Client.Adapters;
using Definux.Emeraude.Client.Models;

namespace Definux.Emeraude.Tests.Project.Seo
{
    public class SitemapComposition : ISitemapComposition
    {
        public async Task<IEnumerable<PageSitemapPattern>> SetupAsync()
        {
            return await Task.FromResult(new List<PageSitemapPattern>());
        }
    }
}