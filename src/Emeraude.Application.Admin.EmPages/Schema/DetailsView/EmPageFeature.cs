using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Components;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Essentials.Helpers;

namespace Emeraude.Application.Admin.EmPages.Schema.DetailsView;

/// <summary>
/// EmPage extension for adding additional model features.
/// </summary>
/// <typeparam name="TModel">EmPage model.</typeparam>
public class EmPageFeature<TModel>
    where TModel : class, IEmPageModel, new()
{
    private EmPageFeatureSourceToParentRelation emPageBasedRelation;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageFeature{TModel}"/> class.
    /// </summary>
    public EmPageFeature()
    {
        this.PageActions = new List<EmPageAction>();
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
    public EmPageComponent FeatureComponentType { get; private set; }

    /// <summary>
    /// List of all page actions for the current EmPage.
    /// </summary>
    public IList<EmPageAction> PageActions { get; }

    /// <summary>
    /// Maps external EmPage model to the feature.
    /// </summary>
    /// <param name="sourceModelProperty"></param>
    /// <param name="parentModelProperty"></param>
    /// <param name="direction"></param>
    /// <typeparam name="TEmPageModel">EmPage model.</typeparam>
    public void MapEmPageModel<TEmPageModel>(
        Expression<Func<TEmPageModel, object>> sourceModelProperty,
        Expression<Func<TModel, object>> parentModelProperty,
        EmPageFeatureReferenceDirection direction)
        where TEmPageModel : class, IEmPageModel, new()
    {
        if (sourceModelProperty == null)
        {
            throw new ArgumentNullException(nameof(sourceModelProperty));
        }

        if (parentModelProperty == null)
        {
            throw new ArgumentNullException(nameof(parentModelProperty));
        }

        var sourceModelPropertyInfo = ReflectionHelpers.GetCorrectPropertyMember(sourceModelProperty) as PropertyInfo;
        if (sourceModelPropertyInfo == null)
        {
            throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {sourceModelProperty.Name}");
        }

        var parentModelPropertyInfo = ReflectionHelpers.GetCorrectPropertyMember(parentModelProperty) as PropertyInfo;
        if (parentModelPropertyInfo == null)
        {
            throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {parentModelProperty.Name}");
        }

        this.emPageBasedRelation = new EmPageFeatureSourceToParentRelation
        {
            ParentProperty = parentModelPropertyInfo,
            SourceProperty = sourceModelPropertyInfo,
            ReferenceDirection = direction,
        };
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
            PageActions = this.PageActions,
            EmPageBasedRelation = this.emPageBasedRelation,
        };
    }
}