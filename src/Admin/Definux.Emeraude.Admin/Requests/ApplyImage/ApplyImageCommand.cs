using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.ApplyImage
{
    /// <summary>
    /// Command for appling an image to entity with image.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public class ApplyImageCommand<TEntity> : IRequest<bool>
        where TEntity : class, IEntityWithImage, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyImageCommand{TEntity}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="imageUrl"></param>
        public ApplyImageCommand(Guid entityId, string imageUrl)
        {
            this.EntityId = entityId;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Entity id.
        /// </summary>
        public Guid EntityId { get; set; }

        /// <summary>
        /// Image URL.
        /// </summary>
        public string ImageUrl { get; set; }
    }
}