using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.EmPages.Services;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails
{
    /// <inheritdoc cref="IEmPageDataDetailsQueryHandler{TDetailsQuery,TEntity,TRequestModel}"/>
    public class EmPageDataDetailsQueryHandler<TEntity, TRequestModel> : IEmPageDataDetailsQueryHandler<EmPageDataDetailsQuery<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        private readonly IEmContextFactory contextFactory;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;
        private readonly IEmPageService emPageService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataDetailsQueryHandler{TEntity,TRequestModel}"/> class.
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        /// <param name="emPageService"></param>
        public EmPageDataDetailsQueryHandler(
            IEmContextFactory contextFactory,
            IMapper mapper,
            IEmLogger logger,
            IEmPageService emPageService)
        {
            this.contextFactory = contextFactory;
            this.mapper = mapper;
            this.logger = logger;
            this.emPageService = emPageService;
        }

        /// <inheritdoc/>
        public async Task<TRequestModel> Handle(EmPageDataDetailsQuery<TEntity, TRequestModel> request, CancellationToken cancellationToken)
        {
            await using var context = await this.contextFactory.CreateDbContextAsync();

            try
            {
                var entity = await context
                    .Set<TEntity>()
                    .FirstOrDefaultAsync(x => x.Id == request.EntityId, cancellationToken);

                var requestModel = this.mapper.Map<TRequestModel>(entity);

                var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(typeof(TEntity), typeof(TRequestModel));
                await this.emPageService.ApplyValuePipesAsync(new[] { requestModel }, schemaDescription.DetailsView.ViewItems);

                return requestModel;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(EmPageDataDetailsQueryHandler<TEntity, TRequestModel>));
                return null;
            }
        }
    }
}
