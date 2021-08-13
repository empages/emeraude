using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Domain.Logging;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Logger
{
    /// <inheritdoc cref="ILoggerContext"/>
    public class LoggerContext : DbContext, ILoggerContext
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly EmLoggerOptions loggerOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerContext"/> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="optionsProvider"></param>
        public LoggerContext(
            DbContextOptions<LoggerContext> options,
            IHttpContextAccessor httpContextAccessor,
            IEmOptionsProvider optionsProvider)
            : base(options)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.loggerOptions = optionsProvider.GetOptions<EmLoggerOptions>();
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
            string textType = this.GetTextType();

            builder
                .Entity<ActivityLog>()
                .Property(x => x.Headers)
                .HasColumnType(textType);

            builder
                .Entity<ErrorLog>()
                .Property(x => x.StackTrace)
                .HasColumnType(textType);

            builder
                .Entity<EmailLog>()
                .Property(x => x.Body)
                .HasColumnType(textType);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

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

        private string GetTextType()
        {
            string textType = this.loggerOptions.ContextProvider switch
            {
                DatabaseContextProvider.MicrosoftSqlServer => "nvarchar(max)",
                DatabaseContextProvider.PostgreSql => "text",
                _ => "text"
            };

            return textType;
        }
    }
}
