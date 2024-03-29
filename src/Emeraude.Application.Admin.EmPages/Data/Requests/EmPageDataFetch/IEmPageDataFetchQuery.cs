﻿using System;
using System.Linq;
using System.Linq.Expressions;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using Emeraude.Essentials.Models;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;

/// <summary>
/// Generic query that returns all entities with or without filter.
/// </summary>
/// <typeparam name="TEntity">Target entity.</typeparam>
/// <typeparam name="TModel">EmPage model.</typeparam>
public interface IEmPageDataFetchQuery<TEntity, TModel> : IRequest<PaginatedList<TModel>>, IEmPageEntityRequest<TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Pagination page index. First index is 1.
    /// </summary>
    int Page { get; set; }

    /// <summary>
    /// Search query string.
    /// </summary>
    string SearchQuery { get; set; }

    /// <summary>
    /// Order expression.
    /// </summary>
    public Expression<Func<TEntity, object>> OrderBy { get; set; }

    /// <summary>
    /// Order type.
    /// </summary>
    public string OrderType { get; set; }

    /// <summary>
    /// Expression for finding an entity.
    /// </summary>
    Expression<Func<TEntity, bool>> FilterExpression { get; set; }

    /// <summary>
    /// Interceptor of the current query. This property contains a function that allows manual logic injection.
    /// </summary>
    Func<IEmPageDataFetchQuery<TEntity, TModel>, IQueryable<TEntity>, IQueryable<TEntity>> QueryInterceptor { get; set; }
}