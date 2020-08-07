using Definux.Emeraude.Domain.Entities;
using MediatR;
using System;

namespace Definux.Emeraude.Admin.Requests.Edit
{
    public interface IEditCommand<TEntity, TRequestModel> : IRequest<Guid?>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        Guid EntityId { get; set; }

        TRequestModel Model { get; set; }
    }
}
