using Definux.Emeraude.Domain.Entities;
using MediatR;
using System;

namespace Definux.Emeraude.Admin.Requests.Create
{
    public interface ICreateCommand<TEntity, TRequestModel> : IRequest<Guid?>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        TRequestModel Model { get; set; }
    }
}
