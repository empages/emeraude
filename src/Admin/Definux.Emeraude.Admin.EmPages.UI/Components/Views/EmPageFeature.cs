using Microsoft.AspNetCore.Components;

namespace Definux.Emeraude.Admin.EmPages.UI.Components.Views
{
    /// <summary>
    /// Abstract feature component that defines the container for a EmPage feature.
    /// </summary>
    public abstract class EmPageFeature : ComponentBase
    {
        /// <summary>
        /// Route segments of the current feature view.
        /// </summary>
        [Parameter]
        public string[] FeatureRouteSegments { get; set; }
    }
}