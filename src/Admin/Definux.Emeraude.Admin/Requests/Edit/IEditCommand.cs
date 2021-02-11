using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.Edit
{
    /// <summary>
    /// Generic query that edit an entity.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TRequestModel">Data transfer object of the target entity.</typeparam>
    public interface IEditCommand<TEntity, TRequestModel> : IRequest<Guid?>, IGenericEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Id of the entity.
        /// </summary>
        Guid EntityId { get; set; }

        /// <summary>
        /// Request model of the command.
        /// </summary>
        TRequestModel Model { get; set; }
    }
}
