using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Data implementation for table view.
    /// </summary>
    public class EntityTableViewData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityTableViewData"/> class.
        /// </summary>
        public EntityTableViewData()
        {
            this.Rows = new List<EntityTableRowModel>();
        }

        /// <summary>
        /// Rows of the table.
        /// </summary>
        public List<EntityTableRowModel> Rows { get; }

        /// <summary>
        /// Pagination model related to the current view.
        /// </summary>
        public PaginationModel PaginationModel { get; set; }
    }
}