using Definux.Emeraude.Application.Common.Interfaces.Shared;
using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Application.Common.Interfaces.Localization
{
    public interface ILocalizationContext : IDatabaseContext
    {
        DbSet<Language> Languages { get; set; }

        DbSet<TranslationKey> Keys { get; set; }

        DbSet<TranslationValue> Values { get; set; }

        DbSet<ContentKey> ContentKeys { get; set; }

        DbSet<StaticContent> StaticContent { get; set; }
    }
}
