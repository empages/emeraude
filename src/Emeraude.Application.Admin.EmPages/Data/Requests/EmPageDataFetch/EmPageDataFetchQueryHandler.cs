using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Services;
using Emeraude.Contracts;
using Emeraude.Essentials.Enumerations;
using Emeraude.Essentials.Extensions;
using Emeraude.Essentials.Helpers;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;

/// <inheritdoc/>
public class EmPageDataFetchQueryHandler<TEntity, TModel> : IEmPageDataFetchQueryHandler<EmPageDataFetchQuery<TEntity, TModel>, TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    private readonly IEmContext context;
    private readonly IMapper mapper;
    private readonly ILogger<EmPageDataFetchQueryHandler<TEntity, TModel>> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDataFetchQueryHandler{TEntity,TModel}"/> class.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    public EmPageDataFetchQueryHandler(
        IEmContext context,
        IMapper mapper,
        ILogger<EmPageDataFetchQueryHandler<TEntity, TModel>> logger)
    {
        this.context = context;
        this.mapper = mapper;
        this.logger = logger;
    }

    /// <inheritdoc/>
    public async Task<PaginatedList<TModel>> Handle(EmPageDataFetchQuery<TEntity, TModel> request, CancellationToken cancellationToken)
    {
        var result = new PaginatedList<TModel>();

        try
        {
            var requestExpression = this.BuildRequestExpression(request);
            if (request.FilterExpression != null)
            {
                requestExpression = ExpressionBuilders.AndAlso(requestExpression, request.FilterExpression);
            }

            result.AllItemsCount = this.context
                .Set<TEntity>()
                .Where(requestExpression)
                .Count();

            result.CurrentPage = request.Page;
            result.PageSize = request.PageSize;

            var entitiesQuery = this.context
                .Set<TEntity>()
                .Where(requestExpression);

            Expression<Func<TEntity, object>> orderExpression = x => x.Id;
            if (request.OrderBy != null)
            {
                orderExpression = request.OrderBy;
            }

            entitiesQuery = entitiesQuery
                .OrderByType(request.OrderType, orderExpression)
                .Skip(result.StartRow)
                .Take(request.PageSize);

            if (request.QueryInterceptor != null)
            {
                entitiesQuery = request.QueryInterceptor(request, entitiesQuery);
            }

            var entities = await entitiesQuery.ToListAsync(cancellationToken);

            result.Items = this.mapper.Map<IEnumerable<TModel>>(entities);
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "EmPage fetch query fails");
        }

        return result;
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
                requestExpression = ExpressionBuilders.AndAlso(requestExpression, expression);
            }
        }

        return requestExpression;
    }
}