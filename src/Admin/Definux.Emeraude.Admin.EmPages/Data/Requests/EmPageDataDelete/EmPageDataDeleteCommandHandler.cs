using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDelete
{
    /// <inheritdoc cref="IEmPageDataDeleteCommandHandler{TDeleteCommand,TEntity}"/>
    public class EmPageDataDeleteCommandHandler<TEntity> : IEmPageDataDeleteCommandHandler<EmPageDataDeleteCommand<TEntity>, TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataDeleteCommandHandler{TEntity}"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        /// <param name="logger"></param>
        public EmPageDataDeleteCommandHandler(IEmContext context, IMapper mapper, IEmLogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> Handle(EmPageDataDeleteCommand<TEntity> request, CancellationToken cancellationToken)
        {
            try
            {
                var dbSet = this.context.Set<TEntity>();
                var currentEntity = await dbSet.FirstOrDefaultAsync(x => x.Id == request.EntityId, cancellationToken);

                if (currentEntity != null)
                {
                    dbSet.Remove(currentEntity);
                    await this.context.SaveChangesAsync(cancellationToken);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(EmPageDataDeleteCommandHandler<TEntity>));
                return false;
            }
        }
    }
}
