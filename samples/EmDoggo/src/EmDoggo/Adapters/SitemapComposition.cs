using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Client.Adapters;
using Definux.Emeraude.Client.Models;
using EmDoggo.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmDoggo.Adapters
{
    public class SitemapComposition : ISitemapComposition
    {
        private readonly ILanguageStore languageStore;
        private readonly IEntityContext entityContext;

        public SitemapComposition(ILanguageStore languageStore, IEntityContext entityContext)
        {
            this.languageStore = languageStore;
            this.entityContext = entityContext;
        }
        
        public async Task<IEnumerable<PageSitemapPattern>> SetupAsync()
        {
            var sitemapPatterns = new List<PageSitemapPattern>();

            sitemapPatterns.Add(new PageSitemapPattern("/", this.languageStore)
            {
                SinglePage = true,
                ChangeFrequency = SeoChangeFrequencyTypes.Monthly
            });
            
            sitemapPatterns.Add(new PageSitemapPattern("/shops/{0}", this.languageStore)
            {
                SinglePage = false,
                ChangeFrequency = SeoChangeFrequencyTypes.Monthly,
                DataAccessor = async () =>
                {
                    return await this.entityContext
                        .Shops
                        .Select(x => new[]
                        {
                            x.Id.ToString()
                        })
                        .ToListAsync();
                }
            });
            
            return sitemapPatterns;
        }
    }
}