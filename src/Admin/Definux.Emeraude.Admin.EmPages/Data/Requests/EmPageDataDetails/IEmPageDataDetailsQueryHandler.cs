using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails
{
    /// <inheritdoc/>
    public interface IEmPageDataDetailsQueryHandler<TDetailsQuery, TEntity, TRequestModel> : IRequestHandler<TDetailsQuery, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TDetailsQuery : IEmPageDataDetailsQuery<TEntity, TRequestModel>
    {
    }
}
