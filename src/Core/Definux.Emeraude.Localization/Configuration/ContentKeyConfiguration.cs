using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Localization.Configuration
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}"/>
    public class ContentKeyConfiguration : IEntityTypeConfiguration<ContentKey>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<ContentKey> builder)
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
