using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIDateTimeElement"/> for tables for showing date and time.
    /// </summary>
    public class TableDateTimeElement : UIDateTimeElement, ITableElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableDateTimeElement"/> class.
        /// </summary>
        public TableDateTimeElement()
            : base(SystemFormats.DateTimeFormat, "DateTime")
        {
        }
    }
}
