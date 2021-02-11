using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Requests.DeleteLog
{
    /// <summary>
    /// Deletes temp file log from the logger context.
    /// </summary>
    public class DeleteTempFileLogCommand : DeleteLogCommand<TempFileLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTempFileLogCommand"/> class.
        /// </summary>
        /// <param name="logId"></param>
        public DeleteTempFileLogCommand(int logId)
            : base(logId)
        {
        }

        /// <inheritdoc/>
        public class DeleteTempFileLogCommandHandler : DeleteLogCommandHandler<DeleteTempFileLogCommand, TempFileLog>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DeleteTempFileLogCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public DeleteTempFileLogCommandHandler(ILoggerContext context)
                : base(context)
            {
            }
        }
    }
}