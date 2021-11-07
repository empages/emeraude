using Definux.Emeraude.Application.Admin.EmPages.Schema;
using Definux.Emeraude.Contracts;
using MediatR;

namespace Definux.Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDetails
{
    /// <inheritdoc/>
    public interface IEmPageDataDetailsQueryHandler<TDetailsQuery, TEntity, TModel> : IRequestHandler<TDetailsQuery, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
        where TDetailsQuery : IEmPageDataDetailsQuery<TEntity, TModel>
    {
    }
}
