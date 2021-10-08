using Microsoft.AspNetCore.Components;

namespace Definux.Emeraude.Admin.EmPages.UI.Components.Base
{
    /// <summary>
    /// Base form component.
    /// </summary>
    public abstract class EmBaseFormElement : EmBaseElement
    {
        /// <summary>
        /// Label of the element.
        /// </summary>
        [Parameter]
        public string Label { get; set; }

        /// <summary>
        /// Event callback that must be invoked when the value of the element is changed.
        /// </summary>
        [Parameter]
        public EventCallback<ChangeEventArgs> OnValueChanged { get; set; }
    }
}