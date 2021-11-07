using System;
using System.Collections.Generic;
using System.Reflection;

namespace Definux.Emeraude.Application.Admin.EmPages.Schema.DetailsView
{
    /// <summary>
    /// EmPage feature description.
    /// </summary>
    public class EmPageFeatureDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageFeatureDescription"/> class.
        /// </summary>
        public EmPageFeatureDescription()
        {
            this.PageActions = new List<EmPageAction>();
            this.Breadcrumbs = new List<EmPageBreadcrumb>();
        }

        /// <inheritdoc cref="EmPageFeature{TModel}.Route"/>
        public string Route { get; set; }

        /// <inheritdoc cref="EmPageFeature{TModel}.Title"/>
        public string Title { get; set; }

        /// <inheritdoc cref="EmPageFeature{TModel}.FeatureComponentType"/>
        public Type FeatureComponentType { get; set; }

        /// <inheritdoc cref="EmPageFeature{TModel}.RouteSegmentsAmount"/>
        public int RouteSegmentsAmount { get; set; }

        /// <inheritdoc cref="EmPageFeature{TModel}.PageActions"/>
        public IList<EmPageAction> PageActions { get; set; }

        /// <inheritdoc cref="EmPageFeature{TModel}.Breadcrumbs"/>
        public IList<EmPageBreadcrumb> Breadcrumbs { get; set; }

        /// <inheritdoc cref="FeatureComponentConfigurationBuilder{TComponent,TModel}"/>
        public EmPageFeatureSourceToParentRelation EmPageBasedRelation { get; set; }

        /// <summary>
        /// Description for parent view of current feature.
        /// </summary>
        public DetailsViewDescription ParentViewDescription { get; set; }
    }
}