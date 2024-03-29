﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Components;
using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Schema.DetailsView;

/// <summary>
/// EmPage feature description.
/// </summary>
public class EmPageFeatureDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageFeatureDescription"/> class.
    /// </summary>
    public EmPageFeatureDescription()
    {
        this.PageActions = new List<EmPageAction>();
    }

    /// <inheritdoc cref="EmPageFeature{TModel}.Route"/>
    public string Route { get; set; }

    /// <inheritdoc cref="EmPageFeature{TModel}.Title"/>
    public string Title { get; set; }

    /// <inheritdoc cref="EmPageFeature{TModel}.FeatureComponentType"/>
    public EmPageComponent FeatureComponentType { get; set; }

    /// <inheritdoc cref="EmPageFeature{TModel}.PageActions"/>
    public IList<EmPageAction> PageActions { get; set; }

    /// <inheritdoc cref="FeatureComponentConfigurationBuilder{TComponent,TModel}"/>
    public EmPageFeatureSourceToParentRelation EmPageBasedRelation { get; set; }

    /// <summary>
    /// Description for parent view of current feature.
    /// </summary>
    public DetailsViewDescription ParentViewDescription { get; set; }
}