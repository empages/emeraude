using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.TableView
{
    /// <summary>
    /// Data implementation for table view.
    /// </summary>
    public class EmPageTableViewData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageTableViewData"/> class.
        /// </summary>
        public EmPageTableViewData()
        {
            this.Rows = new List<EmPageTableRowModel>();
        }

        /// <summary>
        /// Rows of the table.
        /// </summary>
        public List<EmPageTableRowModel> Rows { get; }

        /// <summary>
        /// Pagination model related to the current view.
        /// </summary>
        public PaginationModel PaginationModel { get; set; }
    }
}