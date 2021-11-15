using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Consumer.Adapters;
using Emeraude.Application.Consumer.Models;
using Emeraude.Infrastructure.Localization.Services;

namespace Definux.Emeraude.Tests.Client.Fakes
{
    public class SitemapCompositionFake : ISitemapComposition
    {
        private readonly ILanguageStore languageStore;

        public SitemapCompositionFake(ILanguageStore languageStore)
        {
            this.languageStore = languageStore;
        }
        
        public async Task<IEnumerable<PageSitemapPattern>> SetupAsync()
        {
            string domain = "https://emeraude.dev";
            var patterns = new List<PageSitemapPattern>();
            patterns.Add(new PageSitemapPattern("/home", this.languageStore)
            {
                SinglePage = true,
                ChangeFrequency = SeoChangeFrequencyTypes.Monthly,
                Priority = 0.8f,
                Domain = domain,
            });
            
            patterns.Add(new PageSitemapPattern("/entities/{0}", this.languageStore)
            {
                SinglePage = false,
                ChangeFrequency = SeoChangeFrequencyTypes.Daily,
                Priority = 0.4f,
                Domain = domain,
                DataAccessor = async () =>
                {
                    return await Task.FromResult(new List<string[]>
                    {
                        new[] {"1"},
                        new[] {"2"}
                    });
                },
                LastModificationDates = new List<DateTime>
                {
                    new (2020, 1, 1),
                    new (2020, 2, 2),
                }
            });

            return patterns;
        }
    }
}