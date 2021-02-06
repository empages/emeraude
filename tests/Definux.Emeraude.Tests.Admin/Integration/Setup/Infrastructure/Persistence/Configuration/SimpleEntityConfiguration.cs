using Definux.Emeraude.Tests.Admin.Integration.Setup.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Infrastructure.Persistence.Configuration
{
    public class SimpleEntityConfiguration : IEntityTypeConfiguration<SimpleEntity>
    {
        public void Configure(EntityTypeBuilder<SimpleEntity> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .HasMaxLength(100);
        }
    }
}