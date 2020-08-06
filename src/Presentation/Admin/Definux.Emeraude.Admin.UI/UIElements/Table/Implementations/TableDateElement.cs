using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    public class TableDateElement : UIDateTimeElement, ITableElement
    {
        public TableDateElement()
            : base(SystemFormats.DateFormat, "Date")
        {

        }
    }
}
