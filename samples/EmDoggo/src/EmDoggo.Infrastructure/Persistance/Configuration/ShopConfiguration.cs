using Definux.Utilities.Extensions;
using EmDoggo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmDoggo.Infrastructure.Persistance.Configuration
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder
                .HasMany(x => x.Foods)
                .WithOne(x => x.Shop)
                .HasForeignKey(x => x.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(x => x.Name)
                .HasMaxLength(128);
            
            builder
                .Property(x => x.Description)
                .HasColumnType("text");
        }
    }
}
