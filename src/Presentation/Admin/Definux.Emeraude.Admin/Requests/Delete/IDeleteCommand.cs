using Definux.Emeraude.Domain.Entities;
using MediatR;
using System;

namespace Definux.Emeraude.Admin.Requests.Delete
{
    public interface IDeleteCommand<TEntity> : IRequest<bool>
        where TEntity : class, IEntity, new()
    {
        Guid EntityId { get; set; }
    }
}
