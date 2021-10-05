using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataEdit
{
    /// <summary>
    /// Generic query that edit an entity.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TRequestModel">Data transfer object of the target entity.</typeparam>
    public interface IEmPageDataEditCommand<TEntity, TRequestModel> : IRequest<Guid?>, IEmPageGenericEntityRequest<TEntity>
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
