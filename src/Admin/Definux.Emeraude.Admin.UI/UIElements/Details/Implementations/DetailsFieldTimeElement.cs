using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIDateTimeElement"/> for details cards for showing time.
    /// </summary>
    public class DetailsFieldTimeElement : UIDateTimeElement, IDetailsFieldElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldTimeElement"/> class.
        /// </summary>
        public DetailsFieldTimeElement()
            : base(SystemFormats.TimeFormat, "Time")
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
