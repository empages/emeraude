using System.Collections.Generic;
using Emeraude.Application.Admin.Models;

namespace Emeraude.Application.Admin.EmPages.Models.TableView
{
    /// <summary>
    /// Model implementation for table view.
    /// </summary>
    public class EmPageTableViewModel : EmPageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageTableViewModel"/> class.
        /// </summary>
        /// <param name="context"></param>
        public EmPageTableViewModel(EmPageViewContext context)
            : base(context)
        {
            this.HeadModel = new EmPageTableHeadModel();
            this.RowActions = new List<ActionModel>();
            this.Rows = new List<EmPageTableRowModel>();
        }

        /// <summary>
        /// Head model of the table.
        /// </summary>
        public EmPageTableHeadModel HeadModel { get; }

        /// <summary>
        /// Indicates that the current table items have actions or not.
        /// </summary>
        public bool HasActions { get; set; }

        /// <summary>
        /// Collection of all actions that will be applied to each entity.
        /// </summary>
        public IList<ActionModel> RowActions { get; set; }

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