using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView
{
    /// <summary>
    /// Implementation model of details field.
    /// </summary>
    public class EmPageDetailsFieldModel
    {
        /// <summary>
        /// Title of the field.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Property from which is extracted the value.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Order of the field.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Value of the field.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Raw type of the field.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Render component of the field.
        /// </summary>
        public Type Component { get; set; }

        /// <summary>
        /// Additional parameters for component customization.
        /// </summary>
        public IDictionary<string, object> Parameters { get; set; }
    }
}