using System;
using System.Collections.Generic;
using Emeraude.Application.Admin.EmPages.Models.DetailsView;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;

namespace Emeraude.Application.Admin.EmPages.Models
{
    /// <summary>
    /// Abstract feature component that defines the container for a EmPage feature.
    /// </summary>
    public abstract class EmPageFeature
    {
        /// <summary>
        /// Feature instance.
        /// </summary>
        public EmPageDetailsFeatureModel Feature { get; set; }

        /// <summary>
        /// Route segments of the current feature view.
        /// </summary>
        public string[] FeatureRouteSegments { get; set; }

        /// <summary>
        /// Parent details view model.
        /// </summary>
        public EmPageDetailsViewModel DetailsViewModel { get; set; }
    }
}