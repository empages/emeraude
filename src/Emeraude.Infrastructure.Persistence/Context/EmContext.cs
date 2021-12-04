using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Contracts;
using Emeraude.Essentials.Extensions;
using Emeraude.Infrastructure.Identity.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Emeraude.Infrastructure.Persistence.Context;

/// <summary>
/// Main abstract context of Emeraude application for your database context.
/// </summary>
/// <typeparam name="TContext">Your database context.</typeparam>
public abstract class EmContext<TContext> : IdentityContext<TContext>, IEmContext
    where TContext : EmContext<TContext>
{
    private readonly Guid? currentUserId;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmContext{TContext}"/> class.
    /// </summary>
    /// <param name="options"></param>
    /// <param name="httpAccessor"></param>
    /// <param name="serviceProvider"></param>
    protected EmContext(
        DbContextOptions<TContext> options,
        IHttpContextAccessor httpAccessor,
        IServiceProvider serviceProvider)
        : base(options)
    {
        this.ServiceProvider = serviceProvider;
        this.currentUserId = httpAccessor.GetCurrentUserId();
    }

    /// <inheritdoc cref="IServiceProvider"/>
    public IServiceProvider ServiceProvider { get; }

    /// <inheritdoc/>
    public override int SaveChanges()
    {
        this.UpdateAuditableEntities();
        return base.SaveChanges();
    }

    /// <inheritdoc/>
    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        this.UpdateAuditableEntities();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    /// <inheritdoc/>
    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
    {
        this.UpdateAuditableEntities();
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    /// <inheritdoc/>
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        this.UpdateAuditableEntities();
        return base.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public Type GetContextType()
    {
        return this.GetType();
    }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder = this.ConfigureEntitiesIdentifications(builder);
    }

    /// <summary>
    /// Configure all entities identifications.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    protected virtual ModelBuilder ConfigureEntitiesIdentifications(ModelBuilder builder)
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

    /// <summary>
    /// Method that automatically update all dates and users of all tracked auditable entities.
    /// </summary>
    protected virtual void UpdateAuditableEntities()
    {
        IEnumerable<EntityEntry> modifiedEntityEntries = this.ChangeTracker
            .Entries()
            .Where(x => x.Entity is IAuditableEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

        foreach (EntityEntry entry in modifiedEntityEntries)
        {
            var entity = (IAuditableEntity)entry.Entity;
            DateTime now = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entity.CreatedOn = now;
                entity.CreatedBy = this.currentUserId?.ToString();
            }
            else
            {
                this.Entry(entity).Property(x => x.CreatedOn).IsModified = false;
                this.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
            }

            entity.UpdatedOn = now;
            entity.UpdatedBy = this.currentUserId?.ToString();
        }
    }
}