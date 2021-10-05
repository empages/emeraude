using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <summary>
    /// Generic command that create an entity.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TRequestModel">Data transfer object of the target entity.</typeparam>
    public interface IEmPageDataCreateCommand<TEntity, TRequestModel> : IRequest<Guid?>, IEmPageGenericNewEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Request model of the command.
        /// </summary>
        TRequestModel Model { get; set; }
    }
}
