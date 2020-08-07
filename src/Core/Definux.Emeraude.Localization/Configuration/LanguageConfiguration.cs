using Definux.Emeraude.Domain.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Localization.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Name)
                .HasColumnName("name");

            builder
                .Property(x => x.NativeName)
                .HasColumnName("native_name");

            builder
                .Property(x => x.Code)
                .HasColumnName("code");

            builder
                .HasIndex(x => x.Code)
                .IsUnique(true);

            builder
                .Property(x => x.IsDefault)
                .HasColumnName("is_default");
        }
    }
}
