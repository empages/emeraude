using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Requests.DeleteLog
{
    /// <summary>
    /// Deletes error log from the logger context.
    /// </summary>
    public class DeleteErrorLogCommand : DeleteLogCommand<ErrorLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteErrorLogCommand"/> class.
        /// </summary>
        /// <param name="logId"></param>
        public DeleteErrorLogCommand(int logId)
            : base(logId)
        {
        }

        /// <inheritdoc/>
        public class DeleteErrorLogCommandHandler : DeleteLogCommandHandler<DeleteErrorLogCommand, ErrorLog>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DeleteErrorLogCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public DeleteErrorLogCommandHandler(ILoggerContext context)
                : base(context)
            {
            }
        }
    }
}