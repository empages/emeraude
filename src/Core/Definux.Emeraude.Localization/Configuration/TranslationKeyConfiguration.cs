using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Localization.Configuration
{
    public class TranslationKeyConfiguration : IEntityTypeConfiguration<TranslationKey>
    {
        public void Configure(EntityTypeBuilder<TranslationKey> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Key)
                .HasColumnName("key");

            builder
                .HasIndex(x => x.Key)
                .IsUnique();
        }
    }
}
