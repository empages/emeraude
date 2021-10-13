using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.Schema
{
    /// <summary>
    /// EmPage extension for adding additional model features.
    /// </summary>
    public class EmPageFeature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageFeature"/> class.
        /// </summary>
        public EmPageFeature()
        {
            this.PageActions = new List<EmPageAction>();
            this.Breadcrumbs = new List<EmPageBreadcrumb>();
        }

        /// <summary>
        /// Route of the feature. This property is analogical to the schema route.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Title of the feature.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Type of the component that will contains the content and logic.
        /// </summary>
        public Type FeatureComponentType { get; private set; }

        /// <summary>
        /// List of all page actions for the current EmPage.
        /// </summary>
        public IList<EmPageAction> PageActions { get; }

        /// <summary>
        /// List of all page breadcrumbs for the current EmPage.
        /// </summary>
        public IList<EmPageBreadcrumb> Breadcrumbs { get; }

        /// <summary>
        /// Sets component type of the feature.
        /// </summary>
        /// <typeparam name="TComponent">Component type.</typeparam>
        public void SetComponent<TComponent>()
            where TComponent : UI.Components.Views.EmPageFeature, new()
            => this.FeatureComponentType = typeof(TComponent);
    }
}