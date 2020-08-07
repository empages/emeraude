using Definux.Emeraude.Resources;

namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations
{
    public class DetailsCardTimeElement : UIDateTimeElement, IDetailsCardElement
    {
        public DetailsCardTimeElement()
            : base(SystemFormats.TimeFormat, "Time")
        {
        }

        public bool HasClipboardCopyButton => true;
    }
}
