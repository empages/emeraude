using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIDateTimeElement"/> for tables for showing date.
    /// </summary>
    public class TableDateElement : UIDateTimeElement, ITableElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableDateElement"/> class.
        /// </summary>
        public TableDateElement()
            : base(SystemFormats.DateFormat, "Date")
        {
        }
    }
}
