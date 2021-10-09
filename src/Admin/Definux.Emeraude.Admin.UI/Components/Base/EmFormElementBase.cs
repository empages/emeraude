using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Definux.Emeraude.Admin.UI.Components.Base
{
    /// <summary>
    /// Emeraude base form element that wraps all required events and handlers.
    /// </summary>
    public class EmFormElementBase : ComponentBase
    {
        /// <summary>
        /// Event callback that must be invoked when the value of the element is changed.
        /// </summary>
        [Parameter]
        public EventCallback<ChangeEventArgs> OnValueChanged { get; set; }

        /// <summary>
        /// Emits change event with specified <see cref="ChangeEventArgs"/>.
        /// </summary>
        /// <param name="eventArgs"></param>
        /// <returns></returns>
        protected virtual async Task EmitChangeAsync(ChangeEventArgs eventArgs)
        {
            await this.OnValueChanged.InvokeAsync(eventArgs);
        }
    }
}