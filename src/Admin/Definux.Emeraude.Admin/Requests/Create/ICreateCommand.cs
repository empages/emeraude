using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.Create
{
    /// <summary>
    /// Generic command that create an entity.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TRequestModel">Data transfer object of the target entity.</typeparam>
    public interface ICreateCommand<TEntity, TRequestModel> : IRequest<Guid?>, IGenericNewEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Request model of the command.
        /// </summary>
        TRequestModel Model { get; set; }
    }
}
