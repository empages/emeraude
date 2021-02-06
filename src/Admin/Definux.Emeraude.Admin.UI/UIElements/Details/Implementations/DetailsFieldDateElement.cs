using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIDateTimeElement"/> for details cards for showing date.
    /// </summary>
    public class DetailsFieldDateElement : UIDateTimeElement, IDetailsFieldElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldDateElement"/> class.
        /// </summary>
        public DetailsFieldDateElement()
            : base(SystemFormats.DateFormat, "Date")
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
