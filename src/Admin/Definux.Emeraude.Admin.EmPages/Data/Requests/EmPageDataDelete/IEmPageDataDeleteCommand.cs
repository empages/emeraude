using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDelete
{
    /// <summary>
    /// Generic command that delete an entity.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public interface IEmPageDataDeleteCommand<TEntity> : IRequest<bool>, IEmPageGenericEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// Id of the entity.
        /// </summary>
        Guid EntityId { get; set; }
    }
}
