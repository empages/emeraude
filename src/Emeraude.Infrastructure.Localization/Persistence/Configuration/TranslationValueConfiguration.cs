using Emeraude.Infrastructure.Localization.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emeraude.Infrastructure.Localization.Persistence.Configuration
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}"/>
    public class TranslationValueConfiguration : IEntityTypeConfiguration<TranslationValue>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<TranslationValue> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.LanguageId)
                .HasColumnName("language_id");

            builder
                .HasOne(x => x.Language)
                .WithMany(x => x.Translations)
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(x => x.TranslationKeyId)
                .HasColumnName("translation_key_id");

            builder
                .HasOne(x => x.TranslationKey)
                .WithMany(x => x.Translations)
                .HasForeignKey(x => x.TranslationKeyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(x => x.Value)
                .HasColumnName("value")
                .UseCollation("NOCASE");

            builder
                .Property(x => x.NormalizedValue)
                .HasColumnName("normalized_value")
                .UseCollation("NOCASE");
        }
    }
}
