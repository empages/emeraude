using Definux.Emeraude.Admin.UI.UIElements.Table;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    public class TableCellViewModel
    {
        public TableCellViewModel(int order, object content, ITableElement tableElement)
        {
            Order = order;
            TableElement = tableElement;
            TableElement.DataSource = content;
        }

        public int Order { get; private set; }

        public ITableElement TableElement { get; private set; }

        public IHtmlContent RenderHtmlContent()
        {
            return TableElement.RenderHtmlString();
        }
    }
}
