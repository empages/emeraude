using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    /// <summary>
    /// Implementation of the table of the entity.
    /// </summary>
    public class TableViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewModel"/> class.
        /// </summary>
        public TableViewModel()
        {
            this.Header = new TableHeaderViewModel();
            this.Rows = new List<TableRowViewModel>();
        }

        /// <inheritdoc cref="TableHeaderViewModel"/>
        public TableHeaderViewModel Header { get; set; }

        /// <summary>
        /// Collection of all rows implemented by <see cref="TableRowViewModel"/>.
        /// </summary>
        public List<TableRowViewModel> Rows { get; private set; }

        /// <inheritdoc cref="TablePaginationViewModel"/>
        public TablePaginationViewModel Pagination { get; set; }

        /// <summary>
        /// Flag that indicates that the table has actions for their rows.
        /// </summary>
        public bool HasActions
        {
            get
            {
                return this.Rows.FirstOrDefault() == null ? false : this.Rows.FirstOrDefault().Actions.Any();
            }
        }

        /// <summary>
        /// Name of the area that visualize the table.
        /// </summary>
        public string Area { get; private set; }

        /// <summary>
        /// Name of the controller that visualize the table.
        /// </summary>
        public string Controller { get; private set; }

        /// <summary>
        /// Name of the action that visualize the table.
        /// </summary>
        public string Action { get; private set; }

        /// <summary>
        /// Set pagination redirection core parameters of the table.
        /// </summary>
        /// <param name="area"></param>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        public void SetPaginationRedirection(string area, string controller, string action)
        {
            this.Area = area;
            this.Controller = controller;
            this.Action = action;
        }

        /// <summary>
        /// Add a row to the table.
        /// </summary>
        /// <param name="row"></param>
        public void AddRow(TableRowViewModel row)
        {
            if (row != null)
            {
                this.Rows.Add(row);
            }
        }

        /// <summary>
        /// Set pagination of the table.
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="pagesCount"></param>
        public void SetPagination(int currentPage, int pagesCount)
        {
            this.Pagination = new TablePaginationViewModel(currentPage, pagesCount);
        }
    }
}
