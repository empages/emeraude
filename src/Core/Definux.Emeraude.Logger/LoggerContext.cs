using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Logging;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Definux.Emeraude.Logger
{
    /// <inheritdoc/>
    public class LoggerContext : DbContext, ILoggerContext
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerContext"/> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpContextAccessor"></param>
        public LoggerContext(DbContextOptions<LoggerContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        /// <inheritdoc/>
        public DbSet<ActivityLog> ActivityLogs { get; set; }

        /// <inheritdoc/>
        public DbSet<ErrorLog> ErrorLogs { get; set; }

        /// <inheritdoc/>
        public DbSet<TempFileLog> TempFileLogs { get; set; }

        /// <inheritdoc/>
        public DbSet<EmailLog> EmailLogs { get; set; }

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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<ActivityLog>().ToTable("activity_logs");
            builder.Entity<ErrorLog>().ToTable("error_logs");
            builder.Entity<TempFileLog>().ToTable("temp_file_logs");
            builder.Entity<EmailLog>().ToTable("email_logs");

            base.OnModelCreating(builder);
        }

        /// <summary>
        /// Method that automatically update all dates and users of all tracked entities.
        /// </summary>
        protected virtual void UpdateAuditableEntities()
        {
            IEnumerable<EntityEntry> modifiedEntityEntries = this.ChangeTracker
                .Entries()
                .Where(x => x.Entity is ILoggerEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (EntityEntry entry in modifiedEntityEntries)
            {
                var entity = (ILoggerEntity)entry.Entity;
                DateTime now = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedOn = now;
                    entity.CreatedBy = this.GetCurrentUserId()?.ToString();
                }
            }
        }

        private Guid? GetCurrentUserId()
        {
            var currentUserId = this.httpContextAccessor.GetCurrentUserId();
            if (!currentUserId.HasValue)
            {
                currentUserId = this.httpContextAccessor.HttpContext.GetJwtUserId();
            }

            return currentUserId;
        }
    }
}
