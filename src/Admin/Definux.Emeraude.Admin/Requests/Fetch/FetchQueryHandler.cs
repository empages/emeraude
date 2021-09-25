using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.EmPages;
using Definux.Emeraude.Admin.Services;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Models;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.Requests.Fetch
{
    /// <inheritdoc/>
    public class FetchQueryHandler<TEntity, TRequestModel> : IFetchQueryHandler<FetchQuery<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;
        private readonly IEmPageService emPageService;

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchQueryHandler{TEntity,TRequestModel}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        /// <param name="emPageService"></param>
        public FetchQueryHandler(
            IEmContext context,
            IMapper mapper,
            IEmLogger logger,
            IEmPageService emPageService)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
            this.emPageService = emPageService;
        }

        /// <inheritdoc/>
        public async Task<PaginatedList<TRequestModel>> Handle(FetchQuery<TEntity, TRequestModel> request, CancellationToken cancellationToken)
        {
            PaginatedList<TRequestModel> result = new PaginatedList<TRequestModel>();

            try
            {
                var requestExpression = this.BuildRequestExpression(request);

                result.AllItemsCount = this.context
                        .Set<TEntity>()
                        .Where(requestExpression)
                        .Count();

                result.CurrentPage = request.Page;
                result.PageSize = request.PageSize;

                var orderType = this.GetOrderTypeByString(request.OrderType);
                var entities = this.context
                        .Set<TEntity>()
                        .Where(requestExpression)
                        .OrderByProperty(request.OrderBy, orderType)
                        .Skip(result.StartRow)
                        .Take(request.PageSize)
                        .ToList();

                var entitiesModels = this.mapper.Map<IEnumerable<TRequestModel>>(entities);
                await this.emPageService.ApplyValuePipesAsync(entitiesModels);
                result.Items = entitiesModels;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(FetchQueryHandler<TEntity, TRequestModel>));
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

        private Expression<Func<TEntity, bool>> BuildRequestExpression(FetchQuery<TEntity, TRequestModel> request)
        {
            var expressionList = new List<Expression<Func<TEntity, bool>>>();

            var queryExpressionBySearchQuery = !string.IsNullOrEmpty(request.SearchQuery) ? ExpressionBuilders.BuildQueryExpressionBySearchQuery<TEntity>(request.SearchQuery) : null;
            if (queryExpressionBySearchQuery != null)
            {
                expressionList.Add(queryExpressionBySearchQuery);
            }

            if (request.ParentExpression != null)
            {
                expressionList.Add(request.ParentExpression);
            }

            Expression<Func<TEntity, bool>> requestExpression = x => true;
            if (expressionList.Count > 0)
            {
                foreach (var expression in expressionList)
                {
                    requestExpression = ExpressionFunctions.AndAlso(requestExpression, expression);
                }
            }

            // Special cases
            // var queryExpressionBySearchQueryFromEntityDataPairs = !string.IsNullOrEmpty(request.SearchQuery) ? this.BuildSearchExpressionFromEntityDataPairs(request.SearchQuery) : null;
            // if (queryExpressionBySearchQueryFromEntityDataPairs != null)
            // {
            //     requestExpression = ExpressionFunctions.OrElse(requestExpression, queryExpressionBySearchQueryFromEntityDataPairs);
            // }

            return requestExpression;
        }

        // /// <summary>
        // /// Check for matches in the custom entity data pairs.
        // /// </summary>
        // /// <param name="searchQuery"></param>
        // /// <returns></returns>
        // private Expression<Func<TEntity, bool>> BuildSearchExpressionFromEntityDataPairs(string searchQuery)
        // {
        //     try
        //     {
        //         var tableProperties = AttributesDataExtractors.GetPropertiesWithAttribute<TableColumnAttribute>(typeof(TRequestModel));
        //         var customEntityDataPairs = tableProperties
        //             .Where(x =>
        //                 x.Value
        //                     .UIElementType
        //                     .GetInterfaces()
        //                     .Any(y => y == typeof(IUICustomEntityDataPairBasedElement)))
        //             .Select(x => this.serviceProvider.GetService(x.Value.UIElementType.GetGenericArguments().First()) as ICustomEntityDataPair)
        //             .ToList();
        //
        //         if (!customEntityDataPairs.Any())
        //         {
        //             return null;
        //         }
        //
        //         Expression<Func<TEntity, bool>> resultExpression = x => false;
        //         foreach (var customEntityDataPair in customEntityDataPairs)
        //         {
        //             var propertyOptions = customEntityDataPair
        //                 .Where(x => x.Value.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
        //                 .Select(x => x.Key)
        //                 .ToList();
        //
        //             foreach (var option in propertyOptions)
        //             {
        //                 resultExpression = ExpressionFunctions
        //                     .OrElse(
        //                         ExpressionBuilders.BuildQueryExpressionBySearchQuery<TEntity>(option.ToString()),
        //                         resultExpression);
        //             }
        //         }
        //
        //         return resultExpression;
        //     }
        //     catch (Exception ex)
        //     {
        //         this.logger.LogError(ex);
        //         return null;
        //     }
        // }
    }
}
