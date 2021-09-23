using System.Linq;
using Definux.Emeraude.Essentials.Models;

namespace Definux.Emeraude.Admin.Models
{
    /// <inheritdoc />
    public class TableViewDataRequestGenericResult<TModel> : TableViewDataRequestResult
        where TModel : class, IEntityAdminSchemaModel, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewDataRequestGenericResult{TModel}"/> class.
        /// </summary>
        /// <param name="paginatedEntities"></param>
        public TableViewDataRequestGenericResult(PaginatedList<TModel> paginatedEntities)
        {
            this.CurrentPage = paginatedEntities.CurrentPage;
            this.AllItemsCount = paginatedEntities.AllItemsCount;
            this.PageSize = paginatedEntities.PageSize;
            this.Items = paginatedEntities.Items.Select(x => new TableViewEntity(x));
        }
    }
}