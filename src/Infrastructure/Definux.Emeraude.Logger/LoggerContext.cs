using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Domain.Logging;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Logger
{
    public class LoggerContext : DbContext, ILoggerContext
    {
        public LoggerContext(DbContextOptions<LoggerContext> options, IHttpContextAccessor httpAccessor)
            : base(options)
        {
            CurrentUserId = httpAccessor.GetCurrentUserId();
        }

        public Guid? CurrentUserId { get; set; }

        public DbSet<ActivityLog> ActivityLogs { get; set; }

        public DbSet<ErrorLog> ErrorLogs { get; set; }

        public DbSet<TempFileLog> TempFileLogs { get; set; }

        public DbSet<EmailLog> EmailLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<ActivityLog>().ToTable("activity_logs");
            builder.Entity<ErrorLog>().ToTable("error_logs");
            builder.Entity<TempFileLog>().ToTable("temp_file_logs");
            builder.Entity<EmailLog>().ToTable("email_logs");

            base.OnModelCreating(builder);
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

        protected virtual void UpdateAuditableEntities()
        {
            IEnumerable<EntityEntry> modifiedEntityEntries = ChangeTracker
                .Entries()
                .Where(x => x.Entity is ILoggerEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (EntityEntry entry in modifiedEntityEntries)
            {
                var entity = (ILoggerEntity)entry.Entity;
                DateTime now = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedOn = now;
                    entity.CreatedBy = CurrentUserId?.ToString();
                }
            }
        }
    }
}
