using Definux.Emeraude.Domain.Entities;
using MediatR;
using System;

namespace Definux.Emeraude.Admin.Requests.GetEntityImage
{
    public class GetEntityImageQuery<TEntity> : IRequest<string>
        where TEntity : class, IEntityWithImage, new()
    {
        public GetEntityImageQuery(Guid entityId)
        {
            EntityId = entityId;
        }

        public Guid EntityId { get; set; }
    }
}
