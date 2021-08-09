using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.UI.UIElements.Table;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    /// <summary>
    /// Implementation of table row.
    /// </summary>
    public class TableRowViewModel
    {
        private List<TableCellViewModel> cells = new List<TableCellViewModel>();

        /// <summary>
        /// List of all cells implemented by <see cref="TableCellViewModel"/>.
        /// </summary>
        public List<TableCellViewModel> Cells
        {
            get
            {
                return this.cells.OrderBy(x => x.Order).ToList();
            }
        }

        /// <summary>
        /// Row identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// List of all actions for the row.
        /// </summary>
        public List<TableRowActionViewModel> Actions { get; } = new List<TableRowActionViewModel>();

        /// <summary>
        /// Add cell to the row.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="content"></param>
        /// <param name="tableElement"></param>
        public void AddCell(int order, object content, ITableElement tableElement)
        {
            TableCellViewModel tableCell = new TableCellViewModel(order, content, tableElement);
            this.cells.Add(tableCell);
        }

        /// <summary>
        /// Checks whether exist order with value.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool HasOrder(int order)
        {
            return this.cells.Any(x => x.Order == order);
        }

        /// <summary>
        /// Add action to the row.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="parameters"></param>
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

            this.Actions.Add(newAction);
        }
    }
}
