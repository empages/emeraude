namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UILinkElement"/> for details cards.
    /// </summary>
    public class DetailsFieldLinkElement : UILinkElement, IDetailsFieldElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldLinkElement"/> class.
        /// </summary>
        public DetailsFieldLinkElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
