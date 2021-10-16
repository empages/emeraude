using System;
using System.Threading.Tasks;

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
        /// Retriever function that returns raw model based on the feature configuration.
        /// </summary>
        public Func<Task<object>> RawModelRetriever { get; set; }
    }
}