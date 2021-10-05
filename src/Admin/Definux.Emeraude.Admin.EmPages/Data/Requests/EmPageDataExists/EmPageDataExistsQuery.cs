using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataExists
{
    /// <summary>
    /// Get whether an entity exist or not query..
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public class EmPageDataExistsQuery<TEntity> : IRequest<bool>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataExistsQuery{TEntity}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        public EmPageDataExistsQuery(Guid entityId)
        {
            this.EntityId = entityId;
        }

        /// <summary>
        /// Id of the entity.
        /// </summary>
        public Guid EntityId { get; set; }
    }
}
