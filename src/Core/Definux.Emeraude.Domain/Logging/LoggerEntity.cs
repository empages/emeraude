using System;

namespace Definux.Emeraude.Domain.Logging
{
    /// <summary>
    /// Abstract log entity, parent for all logs into the system.
    /// </summary>
    public abstract class LoggerEntity : ILoggerEntity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public DateTimeOffset CreatedOn { get; set; }

        /// <inheritdoc/>
        public string CreatedBy { get; set; }
    }
}
