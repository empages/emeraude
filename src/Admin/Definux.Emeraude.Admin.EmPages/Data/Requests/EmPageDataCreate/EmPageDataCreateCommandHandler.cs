using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <inheritdoc cref="IEmPageDataCreateCommandHandler{TCreateCommand,TEntity,TModel}"/>
    public class EmPageDataCreateCommandHandler<TEntity, TModel> : IEmPageDataCreateCommandHandler<EmPageDataCreateCommand<TEntity, TModel>, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly IEmContextFactory contextFactory;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataCreateCommandHandler{TEntity,TModel}"/> class.
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public EmPageDataCreateCommandHandler(IEmContextFactory contextFactory, IMapper mapper, IEmLogger logger)
        {
            this.contextFactory = contextFactory;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<Guid?> Handle(EmPageDataCreateCommand<TEntity, TModel> request, CancellationToken cancellationToken)
        {
            await using var context = await this.contextFactory.CreateDbContextAsync(cancellationToken);
            try
            {
                var mappedEntity = this.mapper.Map<TEntity>(request.Model);

                context.Set<TEntity>().Add(mappedEntity);
                await context.SaveChangesAsync(cancellationToken);

                return mappedEntity.Id;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(EmPageDataCreateCommandHandler<TEntity, TModel>));
                return null;
            }
        }
    }
}
