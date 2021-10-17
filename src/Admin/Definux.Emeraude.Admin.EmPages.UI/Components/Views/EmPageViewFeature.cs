using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Utilities;
using Microsoft.AspNetCore.Components;

namespace Definux.Emeraude.Admin.EmPages.UI.Components.Views
{
    /// <summary>
    /// EmPage base feature class applicable for nested EmPage views used as a feature of parent EmPage.
    /// </summary>
    public abstract class EmPageViewFeature : EmPageFeature
    {
        /// <inheritdoc cref="IEmPageManager"/>
        [Inject]
        protected IEmPageManager EmPageManager { get; set; }

        /// <summary>
        /// Type of the route.
        /// </summary>
        protected EmPageRouteType? RouteType { get; set; }

        /// <summary>
        /// Unused feature segments.
        /// </summary>
        protected string[] UnusedSegments { get; set; }

        private EmPageFeatureRoute FeatureRoute => new (this.FeatureRouteSegments);

        /// <inheritdoc/>
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
            this.RouteType = this.FeatureRoute.GetRouteType(out var segmentsForInception);
            this.UnusedSegments = segmentsForInception;
        }
    }
}