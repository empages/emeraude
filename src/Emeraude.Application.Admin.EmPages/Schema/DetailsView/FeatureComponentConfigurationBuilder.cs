using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Essentials.Extensions;
using Emeraude.Essentials.Helpers;
using Microsoft.AspNetCore.Components;

namespace Emeraude.Application.Admin.EmPages.Schema.DetailsView;

/// <summary>
/// Configuration builder for the feature component setup.
/// </summary>
/// <typeparam name="TComponent">Component type.</typeparam>
/// <typeparam name="TModel">EmPage model.</typeparam>
public class FeatureComponentConfigurationBuilder<TComponent, TModel>
    where TComponent : EmPageFeature, new()
    where TModel : class, IEmPageModel, new()
{
    private readonly IDictionary<int, PropertyInfo> routeSegmentToParameterMap;
    private readonly IDictionary<PropertyInfo, PropertyInfo> detailsModelToParameterMap;

    /// <summary>
    /// Initializes a new instance of the <see cref="FeatureComponentConfigurationBuilder{TComponent, TEmPageModel}"/> class.
    /// </summary>
    public FeatureComponentConfigurationBuilder()
    {
        this.routeSegmentToParameterMap = new Dictionary<int, PropertyInfo>();
        this.detailsModelToParameterMap = new Dictionary<PropertyInfo, PropertyInfo>();
    }

    /// <summary>
    /// Route segment to parameter map.
    /// </summary>
    public IReadOnlyDictionary<int, PropertyInfo> RouteSegmentToParameterMap => new ReadOnlyDictionary<int, PropertyInfo>(this.routeSegmentToParameterMap);

    /// <summary>
    /// Details model to parameter map.
    /// </summary>
    public IReadOnlyDictionary<PropertyInfo, PropertyInfo> DetailsModelToParameterMap => new ReadOnlyDictionary<PropertyInfo, PropertyInfo>(this.detailsModelToParameterMap);

    /// <summary>
    /// Map specified details model property to a parameter of the feature component.
    /// </summary>
    /// <param name="modelProperty"></param>
    /// <param name="componentProperty"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="EmPageInvalidSchemaDefinitionException"></exception>
    public void MapDetailsModelToParameter(
        Expression<Func<TModel, object>> modelProperty,
        Expression<Func<TComponent, object>> componentProperty)
    {
        if (modelProperty == null)
        {
            throw new ArgumentNullException(nameof(modelProperty));
        }

        if (componentProperty == null)
        {
            throw new ArgumentNullException(nameof(componentProperty));
        }

        var modelPropertyInfo = ReflectionHelpers.GetCorrectPropertyMember(modelProperty) as PropertyInfo;
        if (modelPropertyInfo == null)
        {
            throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {modelProperty.Name}");
        }

        var componentPropertyInfo = ReflectionHelpers.GetCorrectPropertyMember(componentProperty) as PropertyInfo;
        if (componentPropertyInfo == null)
        {
            throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {componentProperty.Name}");
        }

        if (!componentPropertyInfo.HasAttribute<ParameterAttribute>())
        {
            throw new EmPageInvalidSchemaDefinitionException($"{componentPropertyInfo.Name} does not have ParameterAttribute so model property assignment is not possible");
        }

        this.detailsModelToParameterMap[modelPropertyInfo] = componentPropertyInfo;
    }

    /// <summary>
    /// Maps specified route segment to a parameter of the feature component.
    /// </summary>
    /// <param name="routeSegmentIndex"></param>
    /// <param name="property"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="EmPageInvalidSchemaDefinitionException"></exception>
    public void MapRouteSegmentToParameter(int routeSegmentIndex, Expression<Func<TComponent, object>> property)
    {
        if (property == null)
        {
            throw new ArgumentNullException(nameof(property));
        }

        var propertyInfo = ReflectionHelpers.GetCorrectPropertyMember(property) as PropertyInfo;

        if (propertyInfo == null)
        {
            throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {property.Name}");
        }

        if (!propertyInfo.HasAttribute<ParameterAttribute>())
        {
            throw new EmPageInvalidSchemaDefinitionException($"{propertyInfo.Name} does not have ParameterAttribute so route segment assignment is not possible");
        }

        this.routeSegmentToParameterMap[routeSegmentIndex] = propertyInfo;
    }
}