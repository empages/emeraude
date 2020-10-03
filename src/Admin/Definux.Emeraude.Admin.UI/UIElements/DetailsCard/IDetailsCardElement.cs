using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.UIElements.DetailsCard
{
    /// <summary>
    /// <see cref="IUIElement"/> specified for details card elements.
    /// </summary>
    public interface IDetailsCardElement : IUIElement
    {
        /// <summary>
        /// Flag that activate the button for copy in clipboard.
        /// </summary>
        bool HasClipboardCopyButton { get; }
    }
}
