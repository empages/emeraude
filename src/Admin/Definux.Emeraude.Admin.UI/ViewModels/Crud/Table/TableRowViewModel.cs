using Definux.Emeraude.Admin.UI.UIElements.Table;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.ViewModels.Crud.Table
{
    public class TableRowViewModel
    {
        private List<TableCellViewModel> cells = new List<TableCellViewModel>();
        private List<TableRowActionViewModel> actions = new List<TableRowActionViewModel>();

        public List<TableCellViewModel> Cells
        {
            get
            {
                return this.cells.OrderBy(x => x.Order).ToList();
            }
        }

        public string Identifier { get; set; }

        public List<TableRowActionViewModel> Actions
        {
            get
            {
                return this.actions;
            }
        }

        public void AddCell(int order, object content, ITableElement tableElement)
        {
            TableCellViewModel tableCell = new TableCellViewModel(order, content, tableElement);
            this.cells.Add(tableCell);
        }

        public bool HasOrder(int order)
        {
            return this.cells.Where(x => x.Order == order).Any();
        }

        public void AddAction(TableRowActionViewModel action, List<string> parameters)
        {
            var newAction = new TableRowActionViewModel(
                action.Title,
                action.Icon,
                action.UrlStringFormat,
                action.Parameters,
                action.Method);

            newAction.HasConfirmation = action.HasConfirmation;
            newAction.ConfirmationTitle = action.ConfirmationTitle;
            newAction.ConfirmationMessage = action.ConfirmationMessage;
            newAction.Parameters = parameters;

            this.actions.Add(newAction);
        }
    }
}
