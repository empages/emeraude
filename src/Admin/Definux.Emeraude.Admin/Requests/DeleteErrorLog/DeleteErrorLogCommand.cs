using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Requests.DeleteErrorLog
{
    /// <summary>
    /// Command that delete a specified error log.
    /// </summary>
    public class DeleteErrorLogCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteErrorLogCommand"/> class.
        /// </summary>
        /// <param name="logId"></param>
        public DeleteErrorLogCommand(int logId)
        {
            this.LogId = logId;
        }

        /// <summary>
        /// Id of the log.
        /// </summary>
        public int LogId { get; set; }

        /// <inheritdoc/>
        public class CommandHandler : IRequestHandler<DeleteErrorLogCommand, SimpleResult>
        {
            private readonly ILoggerContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="CommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public CommandHandler(ILoggerContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(DeleteErrorLogCommand request, CancellationToken cancellationToken)
            {
                bool success = false;

                try
                {
                    var errorLog = await this.context
                        .ErrorLogs
                        .FirstOrDefaultAsync(x => x.Id == request.LogId);

                    if (errorLog != null)
                    {
                        this.context.ErrorLogs.Remove(errorLog);
                        await this.context.SaveChangesAsync();

                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                return new SimpleResult(success);
            }
        }
    }
}
