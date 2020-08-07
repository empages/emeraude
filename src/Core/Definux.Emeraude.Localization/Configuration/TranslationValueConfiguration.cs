using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Localization.Configuration
{
    public class TranslationValueConfiguration : IEntityTypeConfiguration<TranslationValue>
    {
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
                .HasColumnName("value");
        }
    }
}
