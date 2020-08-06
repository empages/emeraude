using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Seo.Models;
using System.Linq;

namespace Definux.Emeraude.Client.EmPages.Abstractions
{
    public abstract class EmPageSitemapPattern : PageSitemapPattern
    {
        public EmPageSitemapPattern(string template, ILanguageStore languageStore)
        {
            Patterns.Add(template);
            Patterns.AddRange(languageStore
                .GetLanguages()
                .Where(x => !x.IsDefault)
                .Select(x => $"/{x.Code}{template}")
                .ToList());
        }
    }
}
