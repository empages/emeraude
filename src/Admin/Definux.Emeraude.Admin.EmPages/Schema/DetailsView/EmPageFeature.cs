using System;
using System.Collections.Generic;
using System.Reflection;
using Definux.Emeraude.Admin.EmPages.UI.Models;

namespace Definux.Emeraude.Admin.EmPages.Schema.DetailsView
{
    /// <summary>
    /// EmPage extension for adding additional model features.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class EmPageFeature<TModel>
        where TModel : class, IEmPageModel, new()
    {
        private IReadOnlyDictionary<int, PropertyInfo> routeSegmentToParameterMap;
        private IReadOnlyDictionary<PropertyInfo, PropertyInfo> detailsModelToParameterMap;
        private IReadOnlyDictionary<PropertyInfo, PropertyInfo> emPageModelToParameterMap;
        private Tuple<PropertyInfo, PropertyInfo> emPageBasedLinkConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageFeature{TModel}"/> class.
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
        /// Amount of segments that will be taken from the page route.
        /// Counting of segments starts from the segment next to the feature route.
        /// </summary>
        public int RouteSegmentsAmount { get; set; }

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
        /// <param name="builderAction"></param>
        /// <typeparam name="TComponent">Component type.</typeparam>
        public void SetComponent<TComponent>(Action<FeatureComponentConfigurationBuilder<TComponent, TModel>> builderAction)
            where TComponent : EmPageFeature, new()
        {
            this.FeatureComponentType = typeof(TComponent);
            var featureComponentBuilder = new FeatureComponentConfigurationBuilder<TComponent, TModel>();
            builderAction?.Invoke(featureComponentBuilder);

            this.routeSegmentToParameterMap = featureComponentBuilder.RouteSegmentToParameterMap;
            this.detailsModelToParameterMap = featureComponentBuilder.DetailsModelToParameterMap;
            this.emPageModelToParameterMap = featureComponentBuilder.EmPageModelToParameterMap;
            this.emPageBasedLinkConfiguration = featureComponentBuilder.EmPageBasedLinkConfiguration;
        }

        /// <summary>
        /// Converts current feature to feature description instance.
        /// </summary>
        /// <returns></returns>
        public EmPageFeatureDescription ToDescription()
        {
            return new ()
            {
                Route = this.Route,
                Title = this.Title,
                FeatureComponentType = this.FeatureComponentType,
                RouteSegmentsAmount = this.RouteSegmentsAmount,
                Breadcrumbs = this.Breadcrumbs,
                PageActions = this.PageActions,
                RouteSegmentToParameterMap = this.routeSegmentToParameterMap,
                DetailsModelToParameterMap = this.detailsModelToParameterMap,
                EmPageModelToParameterMap = this.emPageModelToParameterMap,
                EmPageBasedLinkConfiguration = this.emPageBasedLinkConfiguration,
            };
        }
    }
}