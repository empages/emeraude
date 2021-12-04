using System;
using System.Text.Json.Serialization;
using Emeraude.Application.Admin.EmPages.Components;
using Emeraude.Application.Admin.EmPages.Utilities;

namespace Emeraude.Application.Admin.EmPages.Models.DetailsView;

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
    public EmPageComponent Component { get; set; }

    /// <inheritdoc cref="EmPageViewContext"/>
    public EmPageViewContext Context { get; set; }

    /// <summary>
    /// Filter that defines the rules based on the details view.
    /// </summary>
    [JsonIgnore]
    public EmPageDataFilter Filter { get; set; }
}