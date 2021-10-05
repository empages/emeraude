using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails
{
    /// <summary>
    /// Generic query that returns detail information about entity.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TRequestModel">Data transfer object of the target entity.</typeparam>
    public interface IEmPageDataDetailsQuery<TEntity, TRequestModel> : IRequest<TRequestModel>, IEmPageGenericEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Id of the entity.
        /// </summary>
        Guid EntityId { get; set; }
    }
}
