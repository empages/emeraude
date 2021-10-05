using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Localization.Configuration
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}"/>
    public class TranslationKeyConfiguration : IEntityTypeConfiguration<TranslationKey>
    {
        /// <inheritdoc/>
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
                .HasColumnName("key")
                .UseCollation("NOCASE");

            builder
                .HasIndex(x => x.Key)
                .IsUnique();
        }
    }
}
