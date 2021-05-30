using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Application.Localization
{
    /// <summary>
    /// Database context for managing localization resources of the application.
    /// </summary>
    public interface ILocalizationContext : IDatabaseContext
    {
        /// <summary>
        /// Application languages.
        /// </summary>
        DbSet<Language> Languages { get; set; }

        /// <summary>
        /// Translation keys.
        /// </summary>
        DbSet<TranslationKey> Keys { get; set; }

        /// <summary>
        /// Translation values.
        /// </summary>
        DbSet<TranslationValue> Values { get; set; }

        /// <summary>
        /// Static content keys.
        /// </summary>
        DbSet<ContentKey> ContentKeys { get; set; }

        /// <summary>
        /// Static content items.
        /// </summary>
        DbSet<StaticContent> StaticContent { get; set; }
    }
}
