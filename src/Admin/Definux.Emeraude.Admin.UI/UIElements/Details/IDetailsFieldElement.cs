namespace Definux.Emeraude.Admin.UI.UIElements.Details
{
    /// <summary>
    /// <see cref="IUIElement"/> specified for details card elements.
    /// </summary>
    public interface IDetailsFieldElement : IUIElement
    {
        /// <summary>
        /// Flag that activate the button for copy in clipboard.
        /// </summary>
        bool HasClipboardCopyButton { get; }
    }
}
