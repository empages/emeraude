using Emeraude.Infrastructure.Localization.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emeraude.Infrastructure.Localization.Persistence.Configuration;

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
            .HasColumnName("key")
            .UseCollation("NOCASE");

        builder
            .HasIndex(x => x.Key)
            .IsUnique();
    }
}