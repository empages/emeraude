namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UITextElement"/> for details cards.
    /// </summary>
    public class DetailsCardTextElement : UITextElement, IDetailsCardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsCardTextElement"/> class.
        /// </summary>
        public DetailsCardTextElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
