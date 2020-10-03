namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIFlagElement"/> for details cards.
    /// </summary>
    public class DetailsCardFlagElement : UIFlagElement, IDetailsCardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsCardFlagElement"/> class.
        /// </summary>
        public DetailsCardFlagElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => false;
    }
}
