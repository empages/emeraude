using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.ViewModels.Crud.Table
{
    public class TableHeaderViewModel
    {
        private List<TableHeaderCellViewModel> cells = new List<TableHeaderCellViewModel>();
        private int currentCellIndex = 0;

        public TableHeaderViewModel()
        {
        }

        public List<TableHeaderCellViewModel> Cells
        {
            get
            {
                return cells.OrderBy(x => x.Order).ToList();
            }
        }

        public void AddCell(string name)
        {
            this.cells.Add(new TableHeaderCellViewModel
            {
                Order = this.currentCellIndex,
                Name = name
            });

            this.currentCellIndex++;
        }
    }
}
