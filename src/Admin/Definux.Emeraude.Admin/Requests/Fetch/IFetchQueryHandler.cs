using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Models;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.Fetch
{
    /// <summary>
    /// Interface that wraps get all request handler.
    /// </summary>
    /// <typeparam name="TFetchQuery">Fetch query.</typeparam>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TRequestModel">Query response model.</typeparam>
    public interface IFetchQueryHandler<in TFetchQuery, TEntity, TRequestModel> : IRequestHandler<TFetchQuery, PaginatedList<TRequestModel>>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TFetchQuery : IFetchQuery<TEntity, TRequestModel>
    {
    }
}
