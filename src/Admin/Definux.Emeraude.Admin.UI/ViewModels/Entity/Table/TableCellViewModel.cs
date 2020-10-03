using Definux.Emeraude.Admin.UI.UIElements.Table;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    /// <summary>
    /// Implementation of the table cell item.
    /// </summary>
    public class TableCellViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableCellViewModel"/> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="content"></param>
        /// <param name="tableElement"></param>
        public TableCellViewModel(int order, object content, ITableElement tableElement)
        {
            this.Order = order;
            this.TableElement = tableElement;
            this.TableElement.DataSource = content;
        }

        /// <summary>
        /// Order of the cell.
        /// </summary>
        public int Order { get; private set; }

        /// <summary>
        /// Render UI element of the cell.
        /// </summary>
        public ITableElement TableElement { get; private set; }

        /// <summary>
        /// Renders the HTML content for the current cell.
        /// </summary>
        /// <returns></returns>
        public IHtmlContent RenderHtmlContent()
        {
            return this.TableElement.RenderHtmlString();
        }
    }
}
