using System;
using System.Linq;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDetails;

/// <summary>
/// Generic query that returns detail information about entity.
/// </summary>
/// <typeparam name="TEntity">Target entity.</typeparam>
/// <typeparam name="TModel">EmPage model.</typeparam>
public interface IEmPageDataDetailsQuery<TEntity, TModel> : IRequest<TModel>, IEmPageEntityRequest<TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Id of the entity.
    /// </summary>
    Guid EntityId { get; set; }

    /// <summary>
    /// Interceptor of the current query. This property contains a function that allows manual logic injection.
    /// </summary>
    Func<IEmPageDataDetailsQuery<TEntity, TModel>, IQueryable<TEntity>, IQueryable<TEntity>> QueryInterceptor { get; set; }
}