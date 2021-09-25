using System;
using System.Collections.Generic;
using Definux.Emeraude.Admin.Models;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// EmPages schema description.
    /// </summary>
    public class EmPageSchemaDescription
    {
        /// <inheritdoc cref="EmPageSchemaSettings{TModel}.Key"/>
        public string Key { get; set; }

        /// <inheritdoc cref="EmPageSchemaSettings{TModel}.Title"/>
        public string Title { get; set; }

        /// <summary>
        /// Type of the schema linked model.
        /// </summary>
        public Type ModelType { get; set; }

        /// <summary>
        /// Type of the schema linked data controller.
        /// </summary>
        public Type DataControllerType { get; set; }

        /// <summary>
        /// Collection of all model actions.
        /// </summary>
        public IEnumerable<EntityModelAction> ModelActions { get; set; }

        /// <summary>
        /// View items of the table view.
        /// </summary>
        public IEnumerable<TableViewItem> TableViewItems { get; set; }

        /// <summary>
        /// View items of the details view.
        /// </summary>
        public IEnumerable<DetailsViewItem> DetailsViewItems { get; set; }

        /// <summary>
        /// View items of the form view.
        /// </summary>
        public IEnumerable<FormViewItem> FormViewItems { get; set; }
    }
}