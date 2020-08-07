using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.GetAll
{
    public interface IGetAllQuery<TEntity, TRequestModel> : IRequest<PaginatedList<TRequestModel>>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        int Page { get; set; }

        string SearchQuery { get; set; }
    }
}
