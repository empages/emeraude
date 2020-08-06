using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    public class TableTimeElement : UIDateTimeElement, ITableElement
    {
        public TableTimeElement()
            : base(SystemFormats.TimeFormat, "Time")
        {

        }
    }
}
