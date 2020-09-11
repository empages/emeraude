using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using EmDoggoDev.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmDoggoDev.Application.Common.Interfaces.Persistance
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
