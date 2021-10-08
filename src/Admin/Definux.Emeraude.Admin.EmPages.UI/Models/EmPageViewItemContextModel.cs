using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.UI.Models
{
    /// <summary>
    /// View item context model that contains all required data for rendering.
    /// </summary>
    public abstract class EmPageViewItemContextModel
    {
        /// <summary>
        /// Property from which is extracted the value.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Order of the model.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Value of the model.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Raw type of the model.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Render component of the model.
        /// </summary>
        public Type Component { get; set; }

        /// <summary>
        /// Additional parameters for component customization.
        /// </summary>
        public IDictionary<string, object> Parameters { get; set; }
    }
}