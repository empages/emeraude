using System;

namespace Definux.Emeraude.Domain.Logging
{
    /// <summary>
    /// Interface log entity, parent for all logs into the system.
    /// </summary>
    public interface ILoggerEntity
    {
        /// <summary>
        /// Id of the logger entity.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Creation date of the logger entity.
        /// </summary>
        DateTimeOffset CreatedOn { get; set; }

        /// <summary>
        /// Creator id of the logger entity.
        /// </summary>
        string CreatedBy { get; set; }
    }
}
