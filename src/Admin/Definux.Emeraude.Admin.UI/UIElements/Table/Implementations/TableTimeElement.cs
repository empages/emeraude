using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    /// <summary>
    /// Table element for rendering time.
    /// </summary>
    public class TableTimeElement : UIDateTimeElement, ITableElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTimeElement"/> class.
        /// </summary>
        public TableTimeElement()
            : base(SystemFormats.TimeFormat, "Time")
        {
        }
    }
}
