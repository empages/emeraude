using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Models;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.Fetch
{
    /// <summary>
    /// Generic query that returns all entities with or without filter.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TRequestModel">Query response model.</typeparam>
    public interface IFetchQuery<TEntity, TRequestModel> : IRequest<PaginatedList<TRequestModel>>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Pagination page index. First index is 1.
        /// </summary>
        int Page { get; set; }

        /// <summary>
        /// Search query string.
        /// </summary>
        string SearchQuery { get; set; }

        /// <summary>
        /// Order property.
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Order type.
        /// </summary>
        public string OrderType { get; set; }
    }
}
