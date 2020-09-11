using EmDoggoDev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmDoggoDev.Infrastructure.Persistance.Configuration
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder
                .HasMany(x => x.Shops)
                .WithOne(x => x.Food)
                .HasForeignKey(x => x.FoodId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(x => x.Name)
                .HasMaxLength(128);
        }
    }
}
