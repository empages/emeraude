using Definux.Emeraude.Application.Common.Interfaces.Shared;
using Definux.Emeraude.Domain.Logging;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Application.Common.Interfaces.Logging
{
    public interface ILoggerContext : IDatabaseContext
    {
        public DbSet<ActivityLog> ActivityLogs { get; set; }

        public DbSet<ErrorLog> ErrorLogs { get; set; }

        public DbSet<TempFileLog> TempFileLogs { get; set; }

        public DbSet<EmailLog> EmailLogs { get; set; }
    }
}
