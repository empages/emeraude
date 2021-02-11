using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests
{
    /// <summary>
    /// Implementation of generic new entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public abstract class GenericNewEntityRequest<TEntity> : IGenericNewEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <inheritdoc />
        public Guid? ParentId { get; set; }

        /// <inheritdoc />
        public string ParentProperty { get; set; }
    }
}
