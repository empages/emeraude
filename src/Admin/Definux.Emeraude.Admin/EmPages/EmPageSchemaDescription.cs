using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// EmPages schema description.
    /// </summary>
    public class EmPageSchemaDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageSchemaDescription"/> class.
        /// </summary>
        public EmPageSchemaDescription()
        {
            this.TableView = new TableViewDescription();
            this.DetailsView = new DetailsViewDescription();
            this.FormView = new FormViewDescription();
        }

        /// <inheritdoc cref="EmPageSchemaSettings{Entity, Model}.Key"/>
        public string Key { get; set; }

        /// <inheritdoc cref="EmPageSchemaSettings{Entity, Model}.Title"/>
        public string Title { get; set; }

        /// <summary>
        /// Type of the schema linked model.
        /// </summary>
        public Type ModelType { get; set; }

        /// <summary>
        /// Type of the domain entity.
        /// </summary>
        public Type EntityType { get; set; }

        /// <summary>
        /// Type of the schema linked data controller.
        /// </summary>
        public Type DataControllerType { get; set; }

        /// <summary>
        /// Collection of all model actions.
        /// </summary>
        public IEnumerable<EmPageAction> ModelActions { get; set; }

        /// <inheritdoc cref="TableViewDescription"/>
        public TableViewDescription TableView { get; set; }

        /// <inheritdoc cref="DetailsViewDescription"/>
        public DetailsViewDescription DetailsView { get; set; }

        /// <inheritdoc cref="FormViewDescription"/>
        public FormViewDescription FormView { get; set; }
    }
}