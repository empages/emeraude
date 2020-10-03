using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.GetAll
{
    /// <inheritdoc cref="IGetAllQuery{TEntity, TRequestModel}"/>
    public class GetAllQuery<TEntity, TRequestModel> : GenericEntityRequst, IGetAllQuery<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllQuery{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        public GetAllQuery(int page, string searchQuery)
        {
            this.Page = page;
            this.SearchQuery = searchQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllQuery{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="searchQuery"></param>
        /// <param name="foreignKeyProperty"></param>
        /// <param name="foreignKeyValue"></param>
        public GetAllQuery(int page, string searchQuery, string foreignKeyProperty, string foreignKeyValue)
        {
            this.Page = page;
            this.SearchQuery = searchQuery;
            this.ForeignKeyProperty = foreignKeyProperty;
            this.ForeignKeyValue = foreignKeyValue;
        }

        /// <inheritdoc/>
        public int Page { get; set; }

        /// <summary>
        /// Page size for the pagination. Default value is 25.
        /// </summary>
        public int PageSize { get; set; } = 25;

        /// <inheritdoc/>
        public string SearchQuery { get; set; }
    }
}
