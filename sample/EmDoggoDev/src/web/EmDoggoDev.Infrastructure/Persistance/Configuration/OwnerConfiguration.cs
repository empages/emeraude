using Definux.Emeraude.Identity.Entities;
using EmDoggoDev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmDoggoDev.Infrastructure.Persistance.Configuration
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder
                .HasOne(typeof(User))
                .WithMany()
                .HasForeignKey(nameof(Owner.UserId))
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(x => x.Dogs)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(x => x.Address)
                .HasMaxLength(512);
        }
    }
}
