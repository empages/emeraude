using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Requests.DeleteLog
{
    /// <summary>
    /// Deletes email log from the logger context.
    /// </summary>
    public class DeleteEmailLogCommand : DeleteLogCommand<EmailLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEmailLogCommand"/> class.
        /// </summary>
        /// <param name="logId"></param>
        public DeleteEmailLogCommand(int logId)
            : base(logId)
        {
        }

        /// <inheritdoc/>
        public class DeleteEmailLogCommandHandler : DeleteLogCommandHandler<DeleteEmailLogCommand, EmailLog>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DeleteEmailLogCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public DeleteEmailLogCommandHandler(ILoggerContext context)
                : base(context)
            {
            }
        }
    }
}