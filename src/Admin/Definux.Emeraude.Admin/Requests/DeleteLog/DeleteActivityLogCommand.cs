using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Requests.DeleteLog
{
    /// <summary>
    /// Deletes activity log from the logger context.
    /// </summary>
    public class DeleteActivityLogCommand : DeleteLogCommand<ActivityLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteActivityLogCommand"/> class.
        /// </summary>
        /// <param name="logId"></param>
        public DeleteActivityLogCommand(int logId)
            : base(logId)
        {
        }

        /// <inheritdoc/>
        public class DeleteActivityLogCommandHandler : DeleteLogCommandHandler<DeleteActivityLogCommand, ActivityLog>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DeleteActivityLogCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public DeleteActivityLogCommandHandler(ILoggerContext context)
                : base(context)
            {
            }
        }
    }
}