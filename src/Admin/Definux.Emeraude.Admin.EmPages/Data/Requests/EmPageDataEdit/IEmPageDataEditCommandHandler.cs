using System;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataEdit
{
    /// <inheritdoc/>
    public interface IEmPageDataEditCommandHandler<TEditCommand, TEntity, TModel> : IRequestHandler<TEditCommand, Guid?>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
        where TEditCommand : IEmPageDataEditCommand<TEntity, TModel>
    {
    }
}
