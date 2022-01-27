using System;
using System.Linq;
using System.Linq.Expressions;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataRawModel;

/// <inheritdoc/>
public class EmPageDataRawModelQuery<TEntity, TModel> : IEmPageDataRawModelQuery<TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDataRawModelQuery{TEntity,TModel}"/> class.
    /// </summary>
    /// <param name="entityId"></param>
    public EmPageDataRawModelQuery(Guid entityId)
    {
        this.EntityId = entityId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDataRawModelQuery{TEntity, TModel}"/> class.
    /// </summary>
    /// <param name="filterExpression"></param>
    public EmPageDataRawModelQuery(Expression<Func<TEntity, bool>> filterExpression)
    {
        this.FilterExpression = filterExpression;
    }

    /// <inheritdoc/>
    public Guid EntityId { get; set; }

    /// <inheritdoc/>
    public Expression<Func<TEntity, bool>> FilterExpression { get; set; }

    /// <inheritdoc/>
    public Func<IEmPageDataRawModelQuery<TEntity, TModel>, IQueryable<TEntity>, IQueryable<TEntity>> QueryInterceptor { get; set; }
}