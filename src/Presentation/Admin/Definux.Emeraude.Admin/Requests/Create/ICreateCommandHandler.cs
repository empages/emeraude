using Definux.Emeraude.Domain.Entities;
using MediatR;
using System;

namespace Definux.Emeraude.Admin.Requests.Create
{
    public interface ICreateCommandHandler<TCreateCommand, TEntity, TRequestModel> : IRequestHandler<TCreateCommand, Guid?>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TCreateCommand : ICreateCommand<TEntity, TRequestModel>
    {
    }
}
