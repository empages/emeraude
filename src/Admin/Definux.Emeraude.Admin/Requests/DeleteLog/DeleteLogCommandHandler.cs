using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Domain.Logging;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Requests.DeleteLog
{
    /// <inheritdoc/>
    public class DeleteLogCommandHandler<TDeleteLogCommand, TLoggerEntity> : IRequestHandler<TDeleteLogCommand, SimpleResult>
        where TLoggerEntity : class, ILoggerEntity
        where TDeleteLogCommand : DeleteLogCommand<TLoggerEntity>
    {
        private readonly ILoggerContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteLogCommandHandler{TDeleteLogCommand, TLoggerEntity}"/> class.
        /// </summary>
        /// <param name="context"></param>
        public DeleteLogCommandHandler(ILoggerContext context)
        {
            this.context = context;
        }

        /// <inheritdoc/>
        public async Task<SimpleResult> Handle(TDeleteLogCommand request, CancellationToken cancellationToken)
        {
            bool success = false;

            try
            {
                var logEntity = await this.context
                    .Set<TLoggerEntity>()
                    .FirstOrDefaultAsync(x => x.Id == request.LogId, cancellationToken);

                if (logEntity != null)
                {
                    this.context
                        .Set<TLoggerEntity>()
                        .Remove(logEntity);

                    await this.context.SaveChangesAsync(cancellationToken);

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