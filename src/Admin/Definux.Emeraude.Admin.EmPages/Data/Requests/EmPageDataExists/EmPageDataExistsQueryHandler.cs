using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataExists
{
    /// <inheritdoc/>
    public class EmPageDataExistsQueryHandler<TEntity> : IRequestHandler<EmPageDataExistsQuery<TEntity>, bool>
        where TEntity : class, IEntity, new()
    {
        private readonly IEmContext context;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataExistsQueryHandler{TEntity}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        public EmPageDataExistsQueryHandler(IEmContext context, IEmLogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> Handle(EmPageDataExistsQuery<TEntity> request, CancellationToken cancellationToken)
        {
            try
            {
                return await this.context
                    .Set<TEntity>()
                    .AsQueryable()
                    .AnyAsync(x => x.Id == request.EntityId, cancellationToken);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(EmPageDataExistsQueryHandler<TEntity>));
                return false;
            }
        }
    }
}
