using System;
using System.Collections.Generic;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Schema.DetailsView;
using Emeraude.Application.Admin.EmPages.Schema.FormView;
using Emeraude.Application.Admin.EmPages.Schema.IndexView;

namespace Emeraude.Application.Admin.EmPages.Schema
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
            this.IndexView = new IndexViewDescription();
            this.DetailsView = new DetailsViewDescription();
            this.FormView = new FormViewDescription();
        }

        /// <inheritdoc cref="EmPageSchemaSettings{TModel}.Route"/>
        public string Route { get; set; }

        /// <inheritdoc cref="EmPageSchemaSettings{TModel}.Title"/>
        public string Title { get; set; }

        /// <inheritdoc cref="EmPageSchemaSettings{TModel}.UseAsFeature"/>
        public bool UseAsFeature { get; set; }

        /// <summary>
        /// Parent schema in case <see cref="UseAsFeature"/> is true.
        /// </summary>
        public EmPageSchemaDescription ParentSchema { get; set; }

        /// <inheritdoc cref="EmPageFeatureSourceToParentRelation"/>
        public EmPageFeatureSourceToParentRelation ParentRelation { get; set; }

        /// <summary>
        /// Type of the schema linked model.
        /// </summary>
        public Type ModelType { get; set; }

        /// <summary>
        /// Type of the schema linked data manager.
        /// </summary>
        public Type DataManagerType { get; set; }

        /// <summary>
        /// Collection of all model actions.
        /// </summary>
        public IEnumerable<EmPageAction> ModelActions { get; set; }

        /// <inheritdoc cref="IndexViewDescription"/>
        public IndexViewDescription IndexView { get; set; }

        /// <inheritdoc cref="DetailsViewDescription"/>
        public DetailsViewDescription DetailsView { get; set; }

        /// <inheritdoc cref="FormViewDescription"/>
        public FormViewDescription FormView { get; set; }
    }
}