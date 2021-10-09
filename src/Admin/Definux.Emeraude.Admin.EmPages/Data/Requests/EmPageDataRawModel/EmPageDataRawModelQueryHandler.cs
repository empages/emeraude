using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataRawModel
{
    /// <inheritdoc/>
    public class EmPageDataRawModelQueryHandler<TEntity, TModel> : IEmPageDataRawModelQueryHandler<EmPageDataRawModelQuery<TEntity, TModel>, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly IEmContextFactory contextFactory;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataRawModelQueryHandler{TEntity,TModel}"/> class.
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public EmPageDataRawModelQueryHandler(IEmContextFactory contextFactory, IMapper mapper, IEmLogger logger)
        {
            this.contextFactory = contextFactory;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<TModel> Handle(EmPageDataRawModelQuery<TEntity, TModel> request, CancellationToken cancellationToken)
        {
            await using var context = await this.contextFactory.CreateDbContextAsync(cancellationToken);

            try
            {
                return await context
                    .Set<TEntity>()
                    .Where(x => x.Id == request.EntityId)
                    .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(EmPageDataRawModelQueryHandler<TEntity, TModel>));
                return default;
            }
        }
    }
}
