using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.Create
{
    /// <inheritdoc/>
    public interface ICreateCommandHandler<TCreateCommand, TEntity, TRequestModel> : IRequestHandler<TCreateCommand, Guid?>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TCreateCommand : ICreateCommand<TEntity, TRequestModel>
    {
    }
}
