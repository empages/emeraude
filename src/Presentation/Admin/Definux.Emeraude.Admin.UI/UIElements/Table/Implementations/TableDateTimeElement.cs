using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    public class TableDateTimeElement : UIDateTimeElement, ITableElement
    {
        public TableDateTimeElement()
            : base(SystemFormats.DateTimeFormat, "DateTime")
        {

        }
    }
}
