namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UITextElement"/> for details cards.
    /// </summary>
    public class DetailsFieldTextElement : UITextElement, IDetailsFieldElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldTextElement"/> class.
        /// </summary>
        public DetailsFieldTextElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}
