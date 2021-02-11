using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests
{
    /// <summary>
    /// Definition of generic entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public interface IGenericEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// Referenced property expression of the parent entity for current entity.
        /// </summary>
        Expression<Func<TEntity, bool>> ParentExpression { get; set; }
    }
}
