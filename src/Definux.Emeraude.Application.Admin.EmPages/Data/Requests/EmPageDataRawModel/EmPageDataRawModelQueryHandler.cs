using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Application.Admin.EmPages.Schema;
using Definux.Emeraude.Contracts;
using Definux.Emeraude.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataRawModel
{
    /// <inheritdoc/>
    public class EmPageDataRawModelQueryHandler<TEntity, TModel> : IEmPageDataRawModelQueryHandler<EmPageDataRawModelQuery<TEntity, TModel>, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly ILogger<EmPageDataRawModelQueryHandler<TEntity, TModel>> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataRawModelQueryHandler{TEntity,TModel}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public EmPageDataRawModelQueryHandler(IEmContext context, IMapper mapper, ILogger<EmPageDataRawModelQueryHandler<TEntity, TModel>> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<TModel> Handle(EmPageDataRawModelQuery<TEntity, TModel> request, CancellationToken cancellationToken)
        {
            try
            {
                Expression<Func<TEntity, bool>> filterExpression = x => x.Id == request.EntityId;
                if (request.FilterExpression != null)
                {
                    filterExpression = request.FilterExpression;
                }

                return await this.context
                    .Set<TEntity>()
                    .Where(filterExpression)
                    .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "EmPage raw model query fails");
                return default;
            }
        }
    }
}
