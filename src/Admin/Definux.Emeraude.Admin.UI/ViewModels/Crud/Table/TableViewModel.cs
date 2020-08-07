using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.ViewModels.Crud.Table
{
    public class TableViewModel
    {
        public TableViewModel()
        {
            Header = new TableHeaderViewModel();
            Rows = new List<TableRowViewModel>();
        }

        public TableHeaderViewModel Header { get; set; }

        public List<TableRowViewModel> Rows { get; private set; }

        public TablePaginationViewModel Pagination { get; set; }

        public bool HasActions
        {
            get
            {
                return Rows.FirstOrDefault() == null ? false : Rows.FirstOrDefault().Actions.Any();
            }
        }

        public void AddRow(TableRowViewModel row)
        {
            if (row != null)
            {
                Rows.Add(row);
            }
        }

        public void SetPagination(int currentPage, int pagesCount)
        {
            Pagination = new TablePaginationViewModel(currentPage, pagesCount);
        }

        public string Area { get; private set; }

        public string Controller { get; private set; }

        public string Action { get; private set; }

        public void SetPaginationRedirection(string area, string controller, string action)
        {
            Area = area;
            Controller = controller;
            Action = action;
        }
    }
}
