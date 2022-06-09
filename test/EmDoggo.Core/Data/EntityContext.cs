using Microsoft.EntityFrameworkCore;

namespace EmDoggo.Core.Data;

public class EntityContext : DbContext
{
    public EntityContext(DbContextOptions<EntityContext> options)
        : base(options)
    {
    }
    
    public DbSet<Dog> Dogs { get; set; }
    
    public DbSet<Food> Foods { get; set; }
    
    public DbSet<Owner> Owners { get; set; }
    
    public DbSet<Shop> Shops { get; set; }
    
    public DbSet<ShopFood> ShopFoods { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}