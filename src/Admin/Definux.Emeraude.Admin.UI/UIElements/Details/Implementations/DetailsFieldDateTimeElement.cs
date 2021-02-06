using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIDateTimeElement"/> for details cards for showing date and time.
    /// </summary>
    public class DetailsFieldDateTimeElement : UIDateTimeElement, IDetailsFieldElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldDateTimeElement"/> class.
        /// </summary>
        public DetailsFieldDateTimeElement()
            : base(SystemFormats.DateTimeFormat, "DateTime")
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
