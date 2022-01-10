using System.Reflection;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Infrastructure.Persistence.Context;
using EmDoggo.Application.Persistence;
using EmDoggo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmDoggo.Infrastructure.Persistence;

public class EntityContext : EmContext<EntityContext>, IEntityContext
{
    public EntityContext(
        DbContextOptions<EntityContext> options,
        ICurrentUser currentUser)
        : base(options, currentUser)
    {
    }

    public DbSet<Dog> Dogs { get; set; }
    
    public DbSet<Food> Foods { get; set; }
    
    public DbSet<Owner> Owners { get; set; }
    
    public DbSet<Shop> Shops { get; set; }
    
    public DbSet<ShopFood> ShopFoods { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}