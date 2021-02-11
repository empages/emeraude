using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests
{
    /// <summary>
    /// Definition of generic new entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public interface IGenericNewEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// Id of the parent if exists.
        /// </summary>
        Guid? ParentId { get; set; }

        /// <summary>
        /// Property of the parent if exists.
        /// </summary>
        string ParentProperty { get; set; }
    }
}
