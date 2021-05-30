using System;
using Definux.Emeraude.Domain.Logging;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.DeleteLog
{
    /// <summary>
    /// Command that delete a specified log.
    /// </summary>
    /// <typeparam name="TLoggerEntity">Logger entity type.</typeparam>
    public abstract class DeleteLogCommand<TLoggerEntity> : IRequest<SimpleResult>
        where TLoggerEntity : class, ILoggerEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteLogCommand{TLoggerEntity}"/> class.
        /// </summary>
        /// <param name="logId"></param>
        public DeleteLogCommand(int logId)
        {
            this.LogId = logId;
        }

        /// <summary>
        /// Id of the log.
        /// </summary>
        public int LogId { get; set; }

        /// <summary>
        /// Type of the log.
        /// </summary>
        public Type LogType { get; set; }
    }
}
