using EmDoggo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmDoggo.Infrastructure.Persistance.Configuration
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
