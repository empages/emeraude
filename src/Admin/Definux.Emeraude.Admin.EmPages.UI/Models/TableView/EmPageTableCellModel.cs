using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.TableView
{
    /// <summary>
    /// Implementation model of table cell.
    /// </summary>
    public class EmPageTableCellModel
    {
        /// <summary>
        /// Property from which is extracted the value.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Order of the cell.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Value of the cell.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Raw type of the cell.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Render component of the cell.
        /// </summary>
        public Type Component { get; set; }

        /// <summary>
        /// Additional parameters for component customization.
        /// </summary>
        public IDictionary<string, object> Parameters { get; set; }
    }
}