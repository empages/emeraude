using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Requests.DeleteErrorLog
{

    public class DeleteErrorLogCommand : IRequest<SimpleResult>
    {
        public DeleteErrorLogCommand(int logId)
        {
            LogId = logId;
        }

        public int LogId { get; set; }

        public class CommandHandler : IRequestHandler<DeleteErrorLogCommand, SimpleResult>
        {
            private readonly ILoggerContext context;

            public CommandHandler(ILoggerContext context)
            {
                this.context = context;
            }

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
