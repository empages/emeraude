using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.Delete
{
    /// <summary>
    /// Generic command that delete an entity.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public interface IDeleteCommand<TEntity> : IRequest<bool>, IGenericEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// Id of the entity.
        /// </summary>
        Guid EntityId { get; set; }
    }
}
