using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <inheritdoc cref="IEmPageDataCreateCommandHandler{TCreateCommand,TEntity,TRequestModel}"/>
    public class EmPageDataCreateCommandHandler<TEntity, TRequestModel> : IEmPageDataCreateCommandHandler<EmPageDataCreateCommand<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataCreateCommandHandler{TEntity,TRequestModel}"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        /// <param name="logger"></param>
        public EmPageDataCreateCommandHandler(IEmContext context, IMapper mapper, IEmLogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<Guid?> Handle(EmPageDataCreateCommand<TEntity, TRequestModel> request, CancellationToken cancellationToken)
        {
            try
            {
                var mappedEntity = this.mapper.Map<TEntity>(request.Model);

                this.context.Set<TEntity>().Add(mappedEntity);
                await this.context.SaveChangesAsync(cancellationToken);

                return mappedEntity.Id;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(EmPageDataCreateCommandHandler<TEntity, TRequestModel>));
                return null;
            }
        }
    }
}
