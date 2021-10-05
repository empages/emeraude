﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.Services;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Helpers;
using Definux.Emeraude.Essentials.Models;
using Definux.Emeraude.Resources;
using Definux.Utilities.Functions;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch
{
    /// <inheritdoc/>
    public class EmPageDataFetchQueryHandler<TEntity, TRequestModel> : IEmPageDataFetchQueryHandler<EmPageDataFetchQuery<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, IEmPageModel, new()
    {
        private readonly IEmContextFactory contextFactory;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;
        private readonly IEmPageService emPageService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataFetchQueryHandler{TEntity,TRequestModel}"/> class.
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        /// <param name="emPageService"></param>
        public EmPageDataFetchQueryHandler(
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
        public async Task<PaginatedList<TRequestModel>> Handle(EmPageDataFetchQuery<TEntity, TRequestModel> request, CancellationToken cancellationToken)
        {
            await using var context = await this.contextFactory.CreateDbContextAsync();
            var result = new PaginatedList<TRequestModel>();

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

                var entitiesModels = this.mapper.Map<IEnumerable<TRequestModel>>(entities);

                var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(typeof(TEntity), typeof(TRequestModel));
                await this.emPageService.ApplyValuePipesAsync(entitiesModels, schemaDescription.TableView.ViewItems);
                result.Items = entitiesModels;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(EmPageDataFetchQueryHandler<TEntity, TRequestModel>));
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

        private Expression<Func<TEntity, bool>> BuildRequestExpression(EmPageDataFetchQuery<TEntity, TRequestModel> request)
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