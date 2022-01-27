using System;
using System.Linq;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDetails;

/// <inheritdoc cref="IEmPageDataDetailsQuery{TEntity,TModel}"/>
public class EmPageDataDetailsQuery<TEntity, TModel> : IEmPageDataDetailsQuery<TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDataDetailsQuery{TEntity,TModel}"/> class.
    /// </summary>
    /// <param name="entityId"></param>
    public EmPageDataDetailsQuery(Guid entityId)
    {
        this.EntityId = entityId;
    }

    /// <summary>
    /// Id of the entity.
    /// </summary>
    public Guid EntityId { get; set; }

    /// <inheritdoc/>
    public Func<IEmPageDataDetailsQuery<TEntity, TModel>, IQueryable<TEntity>, IQueryable<TEntity>> QueryInterceptor { get; set; }
}