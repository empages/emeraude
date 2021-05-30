using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.GetEntityImage
{
    /// <summary>
    /// Get image of entity.
    /// </summary>
    /// <typeparam name="TEntity">Entity of type <see cref="IEntityWithImage"/>.</typeparam>
    public class GetEntityImageQuery<TEntity> : IRequest<string>
        where TEntity : class, IEntityWithImage, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEntityImageQuery{TEntity}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        public GetEntityImageQuery(Guid entityId)
        {
            this.EntityId = entityId;
        }

        /// <summary>
        /// Id of the entity.
        /// </summary>
        public Guid EntityId { get; set; }
    }
}
