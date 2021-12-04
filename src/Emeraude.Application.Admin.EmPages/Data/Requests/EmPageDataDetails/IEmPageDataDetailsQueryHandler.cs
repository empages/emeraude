using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDetails;

/// <inheritdoc/>
public interface IEmPageDataDetailsQueryHandler<TDetailsQuery, TEntity, TModel> : IRequestHandler<TDetailsQuery, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
    where TDetailsQuery : IEmPageDataDetailsQuery<TEntity, TModel>
{
}