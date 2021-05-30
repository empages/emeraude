using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Application.Logger
{
    /// <summary>
    /// Context that contains all logs saved from the system.
    /// </summary>
    public interface ILoggerContext : IDatabaseContext
    {
        /// <summary>
        /// Logs of all requests and user actions.
        /// </summary>
        public DbSet<ActivityLog> ActivityLogs { get; set; }

        /// <summary>
        /// Logs of all errors and exceptions.
        /// </summary>
        public DbSet<ErrorLog> ErrorLogs { get; set; }

        /// <summary>
        /// Logs of all uploaded files.
        /// </summary>
        public DbSet<TempFileLog> TempFileLogs { get; set; }

        /// <summary>
        /// Logs of all sent and unsent emails.
        /// </summary>
        public DbSet<EmailLog> EmailLogs { get; set; }
    }
}
