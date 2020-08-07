using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    public class DetailsCardDateElement : UIDateTimeElement, IDetailsCardElement
    {
        public DetailsCardDateElement()
            : base(SystemFormats.DateFormat, "Date")
        {
        }

        public bool HasClipboardCopyButton => true;
    }
}
