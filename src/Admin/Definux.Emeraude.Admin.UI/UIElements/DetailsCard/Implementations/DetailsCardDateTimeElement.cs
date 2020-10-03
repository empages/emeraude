using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIDateTimeElement"/> for details cards for showing date and time.
    /// </summary>
    public class DetailsCardDateTimeElement : UIDateTimeElement, IDetailsCardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsCardDateTimeElement"/> class.
        /// </summary>
        public DetailsCardDateTimeElement()
            : base(SystemFormats.DateTimeFormat, "DateTime")
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
