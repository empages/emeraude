using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.UI.Utilities;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView
{
    /// <summary>
    /// EmPage feature implementation model.
    /// </summary>
    public class EmPageDetailsFeatureModel
    {
        /// <summary>
        /// Amount of route segments that are required for the proper work of the feature.
        /// </summary>
        public int RouteSegmentsAmount { get; set; }

        /// <summary>
        /// Feature component.
        /// </summary>
        public Type Component { get; set; }

        /// <inheritdoc cref="EmPageViewContext"/>
        public EmPageViewContext Context { get; set; }

        /// <summary>
        /// Route of the feature's EmPage.
        /// </summary>
        public string EmPageRoute { get; set; }

        /// <summary>
        /// Filter that defines the rules based on the details view.
        /// </summary>
        public EmPageDataFilter Filter { get; set; }
    }
}