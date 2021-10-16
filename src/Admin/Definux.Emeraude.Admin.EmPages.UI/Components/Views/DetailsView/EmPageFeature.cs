using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Microsoft.AspNetCore.Components;

namespace Definux.Emeraude.Admin.EmPages.UI.Components.Views.DetailsView
{
    /// <summary>
    /// Abstract feature component that defines the container for a EmPage feature.
    /// </summary>
    public abstract class EmPageFeature : ComponentBase
    {
        /// <summary>
        /// Feature instance.
        /// </summary>
        [Parameter]
        public EmPageDetailsFeatureModel Feature { get; set; }

        /// <summary>
        /// Route segments of the current feature view.
        /// </summary>
        [Parameter]
        public string[] FeatureRouteSegments { get; set; }

        /// <summary>
        /// Parent details view model.
        /// </summary>
        [Parameter]
        public EmPageDetailsViewModel DetailsViewModel { get; set; }
    }
}