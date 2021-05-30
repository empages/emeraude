using Definux.Emeraude.Application.Persistence;
using EmDoggo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmDoggo.Application.Interfaces
{
    public interface IEntityContext : IEmContext
    {
        DbSet<Dog> Dogs { get; set; }

        DbSet<Food> Foods { get; set; }

        DbSet<Owner> Owners { get; set; }

        DbSet<Shop> Shops { get; set; }

        DbSet<ShopFood> ShopFoods { get; set; }
    }
}
