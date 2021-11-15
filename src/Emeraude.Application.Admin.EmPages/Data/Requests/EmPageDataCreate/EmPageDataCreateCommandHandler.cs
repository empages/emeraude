using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using Emeraude.Infrastructure.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <inheritdoc cref="IEmPageDataCreateCommandHandler{TCreateCommand,TEntity,TModel}"/>
    public class EmPageDataCreateCommandHandler<TEntity, TModel> : IEmPageDataCreateCommandHandler<EmPageDataCreateCommand<TEntity, TModel>, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly ILogger<EmPageDataCreateCommandHandler<TEntity, TModel>> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataCreateCommandHandler{TEntity,TModel}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public EmPageDataCreateCommandHandler(IEmContext context, IMapper mapper, ILogger<EmPageDataCreateCommandHandler<TEntity, TModel>> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<Guid?> Handle(EmPageDataCreateCommand<TEntity, TModel> request, CancellationToken cancellationToken)
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
                this.logger.LogError(ex, "EmPage create command fails");
                return null;
            }
        }
    }
}
