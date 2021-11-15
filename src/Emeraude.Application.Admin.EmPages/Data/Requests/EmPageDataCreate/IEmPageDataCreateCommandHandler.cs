using System;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <inheritdoc/>
    public interface IEmPageDataCreateCommandHandler<TCreateCommand, TEntity, TModel> : IRequestHandler<TCreateCommand, Guid?>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
        where TCreateCommand : IEmPageDataCreateCommand<TEntity, TModel>
    {
    }
}
