using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    /// <summary>
    /// Implementation of a table header.
    /// </summary>
    public class TableHeaderViewModel
    {
        private List<TableHeaderCellViewModel> cells = new List<TableHeaderCellViewModel>();
        private int currentCellIndex = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableHeaderViewModel"/> class.
        /// </summary>
        public TableHeaderViewModel()
        {
        }

        /// <summary>
        /// List of all header cells implemented by <see cref="TableHeaderCellViewModel"/>.
        /// </summary>
        public List<TableHeaderCellViewModel> Cells
        {
            get
            {
                return this.cells.OrderBy(x => x.Order).ToList();
            }
        }

        /// <summary>
        /// Add header cell by name.
        /// </summary>
        /// <param name="name"></param>
        public void AddCell(string name)
        {
            this.cells.Add(new TableHeaderCellViewModel
            {
                Order = this.currentCellIndex,
                Name = name,
            });

            this.currentCellIndex++;
        }
    }
}
