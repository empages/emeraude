using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Definux.Emeraude.Application.Admin.EmPages.Components;

namespace Definux.Emeraude.Application.Admin.EmPages.Models
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
        /// Render component of the model.
        /// </summary>
        public EmPageComponent Component { get; set; }

        /// <summary>
        /// Additional parameters for component customization.
        /// </summary>
        public IEnumerable<Parameter> Parameters { get; set; }
    }
}