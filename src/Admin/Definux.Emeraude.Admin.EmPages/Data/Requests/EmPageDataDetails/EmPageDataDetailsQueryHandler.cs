using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.Services;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails
{
    /// <inheritdoc cref="IEmPageDataDetailsQueryHandler{TDetailsQuery,TEntity,TModel}"/>
    public class EmPageDataDetailsQueryHandler<TEntity, TModel> : IEmPageDataDetailsQueryHandler<EmPageDataDetailsQuery<TEntity, TModel>, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly IEmContextFactory contextFactory;
        private readonly IMapper mapper;
        private readonly ILogger<EmPageDataDetailsQueryHandler<TEntity, TModel>> logger;
        private readonly IEmPageService emPageService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataDetailsQueryHandler{TEntity,TModel}"/> class.
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        /// <param name="emPageService"></param>
        public EmPageDataDetailsQueryHandler(
            IEmContextFactory contextFactory,
            IMapper mapper,
            ILogger<EmPageDataDetailsQueryHandler<TEntity, TModel>> logger,
            IEmPageService emPageService)
        {
            this.contextFactory = contextFactory;
            this.mapper = mapper;
            this.logger = logger;
            this.emPageService = emPageService;
        }

        /// <inheritdoc/>
        public async Task<TModel> Handle(EmPageDataDetailsQuery<TEntity, TModel> request, CancellationToken cancellationToken)
        {
            await using var context = await this.contextFactory.CreateDbContextAsync(cancellationToken);

            try
            {
                var entity = await context
                    .Set<TEntity>()
                    .FirstOrDefaultAsync(x => x.Id == request.EntityId, cancellationToken);

                var requestModel = this.mapper.Map<TModel>(entity);

                var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(typeof(TModel));
                await this.emPageService.ApplyValuePipesAsync(new[] { requestModel }, schemaDescription.DetailsView.ViewItems);

                return requestModel;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "EmPage details query fails");
                return null;
            }
        }
    }
}
