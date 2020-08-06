namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    public class DetailsCardTextElement : UITextElement, IDetailsCardElement
    {
        public DetailsCardTextElement()
            : base()
        {
        }

        public bool HasClipboardCopyButton => true;
    }
}
