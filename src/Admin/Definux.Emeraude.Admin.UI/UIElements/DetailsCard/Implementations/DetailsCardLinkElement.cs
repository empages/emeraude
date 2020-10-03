namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UILinkElement"/> for details cards.
    /// </summary>
    public class DetailsCardLinkElement : UILinkElement, IDetailsCardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsCardLinkElement"/> class.
        /// </summary>
        public DetailsCardLinkElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
