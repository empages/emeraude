using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDelete
{
    /// <inheritdoc cref="IEmPageDataDeleteCommandHandler{TDeleteCommand,TEntity, TModel}"/>
    public class EmPageDataDeleteCommandHandler<TEntity, TModel> : IEmPageDataDeleteCommandHandler<EmPageDataDeleteCommand<TEntity, TModel>, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly IEmContextFactory contextFactory;
        private readonly IMapper mapper;
        private readonly ILogger<EmPageDataDeleteCommandHandler<TEntity, TModel>> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataDeleteCommandHandler{TEntity, TModel}"/> class.
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public EmPageDataDeleteCommandHandler(IEmContextFactory contextFactory, IMapper mapper, ILogger<EmPageDataDeleteCommandHandler<TEntity, TModel>> logger)
        {
            this.contextFactory = contextFactory;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> Handle(EmPageDataDeleteCommand<TEntity, TModel> request, CancellationToken cancellationToken)
        {
            await using var context = await this.contextFactory.CreateDbContextAsync(cancellationToken);
            try
            {
                var dbSet = context.Set<TEntity>();
                var currentEntity = await dbSet.FirstOrDefaultAsync(x => x.Id == request.EntityId, cancellationToken);

                if (currentEntity != null)
                {
                    dbSet.Remove(currentEntity);
                    await context.SaveChangesAsync(cancellationToken);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "EmPage delete command fails");
                return false;
            }
        }
    }
}
