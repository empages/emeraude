using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests
{
    /// <summary>
    /// Implementation of generic entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public abstract class GenericEntityRequst<TEntity> : IGenericEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <inheritdoc/>
        public Expression<Func<TEntity, bool>> ParentExpression { get; set; }
    }
}
