using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.GetAll
{
    /// <summary>
    /// Interface that wraps get all request handler.
    /// </summary>
    /// <typeparam name="TGetAllQuery">Get all query.</typeparam>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TRequestModel">Query response model.</typeparam>
    public interface IGetAllQueryHandler<TGetAllQuery, TEntity, TRequestModel> : IRequestHandler<TGetAllQuery, PaginatedList<TRequestModel>>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TGetAllQuery : IGetAllQuery<TEntity, TRequestModel>
    {
    }
}
