using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Requests.Exists
{
    /// <inheritdoc/>
    public class ExistsQueryHandler<TEntity> : IRequestHandler<ExistsQuery<TEntity>, bool>
        where TEntity : class, IEntity, new()
    {
        private readonly IEmContext context;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExistsQueryHandler{TEntity}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        public ExistsQueryHandler(IEmContext context, ILogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> Handle(ExistsQuery<TEntity> request, CancellationToken cancellationToken)
        {
            try
            {
                return await this.context
                    .Set<TEntity>()
                    .AsQueryable()
                    .AnyAsync(x => x.Id == request.EntityId);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(ExistsQueryHandler<TEntity>));
                return false;
            }
        }
    }
}
