using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.Details
{
    /// <inheritdoc/>
    public interface IDetailsQueryHandler<TDetailsQuery, TEntity, TRequestModel> : IRequestHandler<TDetailsQuery, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TDetailsQuery : IDetailsQuery<TEntity, TRequestModel>
    {
    }
}
