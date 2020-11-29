using Definux.Emeraude.Persistence;
using EmDoggo.Application.Common.Interfaces.Persistance;
using EmDoggo.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace EmDoggo.Infrastructure.Persistance
{
    public class EntityContext : EmContext<EntityContext>, IEntityContext
    {
        public EntityContext(
            DbContextOptions<EntityContext> options,
            IHttpContextAccessor httpAccessor,
            IServiceProvider serviceProvider)
                : base(options, httpAccessor, serviceProvider)
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
}
