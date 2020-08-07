using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    public class DetailsCardDateTimeElement : UIDateTimeElement, IDetailsCardElement
    {
        public DetailsCardDateTimeElement()
            : base(SystemFormats.DateTimeFormat, "DateTime")
        {
        }

        public bool HasClipboardCopyButton => true;
    }
}
