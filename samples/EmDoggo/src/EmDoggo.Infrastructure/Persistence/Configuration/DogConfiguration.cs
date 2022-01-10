using EmDoggo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmDoggo.Infrastructure.Persistence.Configuration
{
    public class DogConfiguration : IEntityTypeConfiguration<Dog>
    {
        public void Configure(EntityTypeBuilder<Dog> builder)
        {
            builder
                .Property(x => x.Name)
                .HasMaxLength(128);
        }
    }
}
