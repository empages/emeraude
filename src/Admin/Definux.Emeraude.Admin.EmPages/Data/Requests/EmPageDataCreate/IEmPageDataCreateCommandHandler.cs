using System;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <inheritdoc/>
    public interface IEmPageDataCreateCommandHandler<TCreateCommand, TEntity, TModel> : IRequestHandler<TCreateCommand, Guid?>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
        where TCreateCommand : IEmPageDataCreateCommand<TEntity, TModel>
    {
    }
}
