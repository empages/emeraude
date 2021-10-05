using System;
using Microsoft.AspNetCore.Components;

namespace Definux.Emeraude.Admin.EmPages.UI.Components.Base
{
    /// <summary>
    /// Base component.
    /// </summary>
    public abstract class EmBaseElement : ComponentBase
    {
        /// <summary>
        /// Property of the entity field rendered by the component.
        /// </summary>
        [Parameter]
        public string Property { get; set; }

        /// <summary>
        /// Value of the entity field rendered by the component.
        /// </summary>
        [Parameter]
        public object Value { get; set; }

        /// <summary>
        /// Type of the entity field rendered by the component.
        /// </summary>
        [Parameter]
        public Type Type { get; set; }
    }
}