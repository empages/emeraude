using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard
{
    public interface IDetailsCardElement : IUIElement
    {
        bool HasClipboardCopyButton { get; }
    }
}
