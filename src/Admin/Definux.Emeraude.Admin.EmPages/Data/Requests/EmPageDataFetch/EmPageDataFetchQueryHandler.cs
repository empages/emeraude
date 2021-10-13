using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.Services;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Enumerations;
using Definux.Emeraude.Essentials.Helpers;
using Definux.Emeraude.Essentials.Models;
using Definux.Utilities.Functions;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch
{
    /// <inheritdoc/>
    public class EmPageDataFetchQueryHandler<TEntity, TModel> : IEmPageDataFetchQueryHandler<EmPageDataFetchQuery<TEntity, TModel>, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly IEmContextFactory contextFactory;
        private readonly IMapper mapper;
        private readonly ILogger<EmPageDataFetchQueryHandler<TEntity, TModel>> logger;
        private readonly IEmPageService emPageService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataFetchQueryHandler{TEntity,TModel}"/> class.
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        /// <param name="emPageService"></param>
        public EmPageDataFetchQueryHandler(
            IEmContextFactory contextFactory,
            IMapper mapper,
            ILogger<EmPageDataFetchQueryHandler<TEntity, TModel>> logger,
            IEmPageService emPageService)
        {
            this.contextFactory = contextFactory;
            this.mapper = mapper;
            this.logger = logger;
            this.emPageService = emPageService;
        }

        /// <inheritdoc/>
        public async Task<PaginatedList<TModel>> Handle(EmPageDataFetchQuery<TEntity, TModel> request, CancellationToken cancellationToken)
        {
            await using var context = await this.contextFactory.CreateDbContextAsync(cancellationToken);
            var result = new PaginatedList<TModel>();

            try
            {
                var requestExpression = this.BuildRequestExpression(request);

                result.AllItemsCount = context
                    .Set<TEntity>()
                    .Where(requestExpression)
                    .Count();

                result.CurrentPage = request.Page;
                result.PageSize = request.PageSize;

                var orderType = this.GetOrderTypeByString(request.OrderType);
                var entities = context
                    .Set<TEntity>()
                    .Where(requestExpression)
                    .OrderByProperty(request.OrderBy, nameof(IEntity.Id), orderType)
                    .Skip(result.StartRow)
                    .Take(request.PageSize)
                    .ToList();

                var entitiesModels = this.mapper.Map<IEnumerable<TModel>>(entities);

                var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(typeof(TModel));
                await this.emPageService.ApplyValuePipesAsync(entitiesModels, schemaDescription.TableView.ViewItems);
                result.Items = entitiesModels;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "EmPage fetch query fails");
            }

            return result;
        }

        private OrderType GetOrderTypeByString(string orderTypeString)
        {
            var orderType = OrderType.Unspecified;
            if (!string.IsNullOrEmpty(orderTypeString))
            {
                if (orderTypeString.ToLower() == "asc")
                {
                    orderType = OrderType.Ascending;
                }
                else if (orderTypeString.ToLower() == "desc")
                {
                    orderType = OrderType.Descending;
                }
            }

            return orderType;
        }

        private Expression<Func<TEntity, bool>> BuildRequestExpression(EmPageDataFetchQuery<TEntity, TModel> request)
        {
            var expressionList = new List<Expression<Func<TEntity, bool>>>();

            var queryExpressionBySearchQuery = !string.IsNullOrEmpty(request.SearchQuery) ? ExpressionBuilders.BuildQueryExpressionBySearchQuery<TEntity>(request.SearchQuery) : null;
            if (queryExpressionBySearchQuery != null)
            {
                expressionList.Add(queryExpressionBySearchQuery);
            }

            Expression<Func<TEntity, bool>> requestExpression = x => true;
            if (expressionList.Count > 0)
            {
                foreach (var expression in expressionList)
                {
                    requestExpression = ExpressionFunctions.AndAlso(requestExpression, expression);
                }
            }

            return requestExpression;
        }
    }
}
