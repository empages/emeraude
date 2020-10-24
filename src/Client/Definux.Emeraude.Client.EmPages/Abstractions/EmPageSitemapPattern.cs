using System.Linq;
using Definux.Emeraude.Application.Localization;
using Definux.Seo.Models;

namespace Definux.Emeraude.Client.EmPages.Abstractions
{
    /// <summary>
    /// Abstract class that implements the <see cref="PageSitemapPattern"/> for the purposes of EmPages.
    /// </summary>
    public abstract class EmPageSitemapPattern : PageSitemapPattern
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageSitemapPattern"/> class.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="languageStore"></param>
        public EmPageSitemapPattern(string template, ILanguageStore languageStore)
        {
            this.Patterns.Add(template);
            this.Patterns.AddRange(languageStore
                .GetLanguages()
                .Where(x => !x.IsDefault)
                .Select(x => $"/{x.Code}{template}")
                .ToList());
        }
    }
}
