using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch
{
    /// <inheritdoc cref="IEmPageDataFetchQuery{TEntity,TRequestModel}"/>
    public class EmPageDataFetchQuery<TEntity, TRequestModel> : EmPageGenericEntityRequst<TEntity>, IEmPageDataFetchQuery<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, IEmPageModel, new()
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
