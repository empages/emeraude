using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form
{
    /// <summary>
    /// <see cref="IUIElement"/> specified for form elements.
    /// </summary>
    public interface IFormElement : IUIElement
    {
        /// <summary>
        /// Label of the form element.
        /// </summary>
        string Label { get; set; }

        /// <summary>
        /// Target property of the form element.
        /// </summary>
        string TargetProperty { get; set; }

        /// <summary>
        /// Visible property of the form element object.
        /// </summary>
        string VisibleKey { get; set; }

        /// <summary>
        /// Value of the form element.
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Flag that indicates whether the value supports null.
        /// </summary>
        bool IsNullable { get; }

        /// <summary>
        /// Flag that indicate that the form element is hidden in the form.
        /// </summary>
        bool Hidden { get; }
    }
}
