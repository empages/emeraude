using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Consumer.Adapters;
using Definux.Emeraude.Application.Consumer.Models;
using Definux.Emeraude.Infrastructure.Localization.Services;

namespace Definux.Emeraude.Tests.Project.Adapters
{
    public class SitemapComposition : ISitemapComposition
    {
        private readonly ILanguageStore languageStore;

        public SitemapComposition(ILanguageStore languageStore)
        {
            this.languageStore = languageStore;
        }
        
        public async Task<IEnumerable<PageSitemapPattern>> SetupAsync()
        {
            var sitemapPatterns = new List<PageSitemapPattern>
            {
                new ("/test", this.languageStore)
                {
                    SinglePage = true,
                    ChangeFrequency = SeoChangeFrequencyTypes.Yearly,
                    Priority = 0.5f
                }
            };

            return await Task.FromResult(sitemapPatterns);
        }
    }
}