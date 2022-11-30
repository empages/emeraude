using System;
using System.Reflection;
using EmPages.Pages.Components;

namespace EmPages.Pages;

/// <summary>
/// Contract that represents page view item.
/// </summary>
public interface IEmPageViewItem
{
    /// <summary>
    /// Visualization text of the item.
    /// </summary>
    string Label { get; set; }

    /// <summary>
    /// Order of the item.
    /// </summary>
    int Order { get; set; }

    /// <summary>
    /// Component that will be used as a visualization strategy by the framework.
    /// </summary>
    EmComponent Component { get; set; }

    /// <summary>
    /// Default component for current item.
    /// </summary>
    EmComponent DefaultComponent { get; }

    /// <summary>
    /// Additional custom parameters for the purposes of rendering.
    /// That property will be transferred directly to the target component.
    /// </summary>
    object Parameters { get; }

    /// <summary>
    /// Name of the model's property.
    /// </summary>
    string SourceName { get; }

    /// <summary>
    /// Type of the model's property.
    /// </summary>
    Type SourceType { get; }

    /// <summary>
    /// Load source information for the current model's property. This method is invoked by the framework.
    /// </summary>
    /// <param name="propertyInfo"></param>
    void LoadSourceInfo(PropertyInfo propertyInfo);

    /// <summary>
    /// Set component for the current view item.
    /// </summary>
    /// <param name="componentAction"></param>
    /// <typeparam name="TComponent">Type of the component.</typeparam>
    void SetComponent<TComponent>(Action<TComponent> componentAction = null)
        where TComponent : EmComponent, new();

    /// <summary>
    /// Set the default component.
    /// </summary>
    void SetDefaultComponent();
}