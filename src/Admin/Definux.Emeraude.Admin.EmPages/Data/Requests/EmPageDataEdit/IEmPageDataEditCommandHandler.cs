using System;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataEdit
{
    /// <inheritdoc/>
    public interface IEmPageDataEditCommandHandler<TEditCommand, TEntity, TRequestModel> : IRequestHandler<TEditCommand, Guid?>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TEditCommand : IEmPageDataEditCommand<TEntity, TRequestModel>
    {
    }
}
