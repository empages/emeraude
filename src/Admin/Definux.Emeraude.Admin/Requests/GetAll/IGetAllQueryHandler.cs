using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.GetAll
{
    public interface IGetAllQueryHandler<TGetAllQuery, TEntity, TRequestModel> : IRequestHandler<TGetAllQuery, PaginatedList<TRequestModel>>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
        where TGetAllQuery : IGetAllQuery<TEntity, TRequestModel>
    {
    }
}
