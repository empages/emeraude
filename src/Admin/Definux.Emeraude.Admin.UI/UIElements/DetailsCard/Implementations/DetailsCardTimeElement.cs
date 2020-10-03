using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIDateTimeElement"/> for details cards for showing time.
    /// </summary>
    public class DetailsCardTimeElement : UIDateTimeElement, IDetailsCardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsCardTimeElement"/> class.
        /// </summary>
        public DetailsCardTimeElement()
            : base(SystemFormats.TimeFormat, "Time")
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
