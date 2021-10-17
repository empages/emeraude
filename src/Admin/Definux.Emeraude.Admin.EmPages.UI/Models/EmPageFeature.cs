using System;
using System.Collections.Generic;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.UI.Models
{
    /// <summary>
    /// Abstract feature component that defines the container for a EmPage feature.
    /// </summary>
    public abstract class EmPageFeature : ComponentBase
    {
        /// <inheritdoc cref="NavigationManager"/>
        [Inject]
        public NavigationManager NavigationManager { get; set; }

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

        /// <summary>
        /// Gets query params of current page.
        /// </summary>
        /// <returns></returns>
        protected IDictionary<string, StringValues> GetQueryParameters()
        {
            var queryString = new Uri(this.NavigationManager.Uri).Query;
            return QueryHelpers.ParseQuery(queryString);
        }
    }
}