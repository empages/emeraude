using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Client.Seo;
using Definux.Emeraude.Client.Seo.Models;

namespace Definux.Emeraude.Tests.Project.Seo
{
    public class SitemapComposition : ISitemapComposition
    {
        public async Task<IEnumerable<PageSitemapPattern>> SetupAsync()
        {
            return new List<PageSitemapPattern>();
        }
    }
}