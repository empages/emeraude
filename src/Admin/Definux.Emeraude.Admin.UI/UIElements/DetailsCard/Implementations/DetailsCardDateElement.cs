using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIDateTimeElement"/> for details cards for showing date.
    /// </summary>
    public class DetailsCardDateElement : UIDateTimeElement, IDetailsCardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsCardDateElement"/> class.
        /// </summary>
        public DetailsCardDateElement()
            : base(SystemFormats.DateFormat, "Date")
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
