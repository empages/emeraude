using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Fetch
{
    /// <inheritdoc cref="IFetchQuery{TEntity,TRequestModel}"/>
    public class FetchQuery<TEntity, TRequestModel> : GenericEntityRequst<TEntity>, IFetchQuery<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <inheritdoc/>
        public int Page { get; set; }

        /// <summary>
        /// Page size for the pagination. Default value is 25.
        /// </summary>
        public int PageSize { get; set; } = 25;

        /// <inheritdoc/>
        public string SearchQuery { get; set; }

        /// <inheritdoc/>
        public string OrderBy { get; set; }

        /// <inheritdoc/>
        public string OrderType { get; set; }
    }
}
