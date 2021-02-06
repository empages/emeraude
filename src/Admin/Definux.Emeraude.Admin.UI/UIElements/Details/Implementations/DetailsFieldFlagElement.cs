namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIFlagElement"/> for details cards.
    /// </summary>
    public class DetailsFieldFlagElement : UIFlagElement, IDetailsFieldElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldFlagElement"/> class.
        /// </summary>
        public DetailsFieldFlagElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => false;
    }
}
