using System;
using System.Collections.Generic;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Components;

namespace Emeraude.Application.Admin.EmPages.Schema;

/// <summary>
/// Contract for view item used as a main unit in schema definition.
/// </summary>
public interface IViewItem
{
    /// <summary>
    /// Title of the item. If it is left empty the property name will be used as a title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Order of the item. If it is left unset the registration order will be taken as a order.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Type of the component used for item rendering.
    /// </summary>
    public EmPageComponent Component { get; }

    /// <summary>
    /// Additional custom parameters for the purposes of rendering.
    /// </summary>
    public object Parameters { get; }

    /// <summary>
    /// Name of the view item source.
    /// </summary>
    public string SourceName { get; }

    /// <summary>
    /// Type of the view item source.
    /// </summary>
    public Type SourceType { get; }

    /// <summary>
    /// Load source information for the current view item. This method is invoked by the framework.
    /// </summary>
    /// <param name="propertyInfo"></param>
    void LoadSourceInfo(PropertyInfo propertyInfo);

    /// <summary>
    /// Set component for the current view item.
    /// </summary>
    /// <param name="componentAction"></param>
    /// <typeparam name="TComponent">Type of the component.</typeparam>
    void SetComponent<TComponent>(Action<TComponent> componentAction = null)
        where TComponent : EmPageComponent, new();
}