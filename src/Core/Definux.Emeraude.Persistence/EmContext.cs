using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Persistence
{
    public abstract class EmContext<TContext> : IdentityContext<TContext>, IEmContext
        where TContext : EmContext<TContext>
    {
        protected readonly IServiceProvider serviceProvider;

        public EmContext(
            DbContextOptions<TContext> options, 
            IHttpContextAccessor httpAccessor, 
            IServiceProvider serviceProvider) : base(options)
        {
            this.serviceProvider = serviceProvider;
            CurrentUserId = httpAccessor.GetCurrentUserId();
        }

        public Guid? CurrentUserId { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder = ApplyEntitiesRelations(builder);
        }

        public override int SaveChanges()
        {
            UpdateAuditableEntities();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            UpdateAuditableEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditableEntities();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditableEntities();
            return base.SaveChangesAsync(cancellationToken);
        }

        public Type GetContextType()
        {
            return GetType();
        }

        protected virtual ModelBuilder ApplyEntitiesRelations(ModelBuilder builder)
        {
            var entitiesTypes = builder.Model.GetEntityTypes();

            foreach (var entityType in entitiesTypes)
            {
                if (entityType.ClrType.GetInterface(nameof(IEntity)) != null)
                {
                    builder
                        .Entity(entityType.ClrType)
                        .HasKey("Id");

                    builder
                        .Entity(entityType.ClrType)
                        .Property("Id")
                        .ValueGeneratedOnAdd();
                }
            }

            return builder;
        }

        protected virtual void UpdateAuditableEntities()
        {
            IEnumerable<EntityEntry> modifiedEntityEntries = ChangeTracker
                .Entries()
                .Where(x => x.Entity is IAuditableEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (EntityEntry entry in modifiedEntityEntries)
            {
                var entity = (IAuditableEntity)entry.Entity;
                DateTime now = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedOn = now;
                    entity.CreatedBy = CurrentUserId?.ToString();
                }
                else
                {
                    base.Entry(entity).Property(x => x.CreatedOn).IsModified = false;
                    base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                }

                entity.UpdatedOn = now;
                entity.UpdatedBy = CurrentUserId?.ToString();
            }
        }
    }
}
