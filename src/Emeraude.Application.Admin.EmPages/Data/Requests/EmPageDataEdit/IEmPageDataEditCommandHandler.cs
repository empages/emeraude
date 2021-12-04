using System;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataEdit;

/// <inheritdoc/>
public interface IEmPageDataEditCommandHandler<TEditCommand, TEntity, TModel> : IRequestHandler<TEditCommand, Guid?>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
    where TEditCommand : IEmPageDataEditCommand<TEntity, TModel>
{
}