using Definux.Emeraude.Domain.Entities;
using MediatR;
using System;

namespace Definux.Emeraude.Admin.Requests.ApplyImage
{
    public class ApplyImageCommand<TEntity> : IRequest<bool>
        where TEntity : class, IEntityWithImage, new()
    {
        public ApplyImageCommand(Guid entityId, string imageUrl)
        {
            EntityId = entityId;
            ImageUrl = imageUrl;
        }

        public Guid EntityId { get; set; }

        public string ImageUrl { get; set; }
    }
}
