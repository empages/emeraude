using Definux.Emeraude.Domain.Entities;
using MediatR;
using System;

namespace Definux.Emeraude.Admin.Requests.Exists
{
    public class ExistsQuery<TEntity> : IRequest<bool>
        where TEntity : class, IEntity, new()
    {
        public ExistsQuery(Guid entityId)
        {
            EntityId = entityId;
        }

        public Guid EntityId { get; set; }
    }
}
