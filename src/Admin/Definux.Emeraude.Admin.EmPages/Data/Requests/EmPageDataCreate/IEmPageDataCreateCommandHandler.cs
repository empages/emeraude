using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <inheritdoc/>
    public interface IEmPageDataCreateCommandHandler<TCreateCommand, TEntity, TRequestModel> : IRequestHandler<TCreateCommand, Guid?>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TCreateCommand : IEmPageDataCreateCommand<TEntity, TRequestModel>
    {
    }
}
