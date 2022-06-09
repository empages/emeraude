using System;
using System.Reflection;
using EmPages.Pages.Components.Renderers;
using Essentials.Extensions;

namespace EmPages.Pages;

/// <summary>
/// Abstract implementation of page view item.
/// </summary>
public abstract class EmPageViewItem : IEmPageViewItem
{
    /// <inheritdoc/>
    public string Label { get; set; }

    /// <inheritdoc/>
    public int Order { get; set; } = -1;

    /// <inheritdoc/>
    public EmComponent Component { get; set; }

    /// <inheritdoc/>
    public object Parameters { get; private set; }

    /// <inheritdoc/>
    public string SourceName { get; private set; }

    /// <inheritdoc/>
    public Type SourceType { get; private set; }

    /// <inheritdoc/>
    public virtual EmComponent DefaultComponent => new TextRenderer();

    /// <inheritdoc/>
    public void LoadSourceInfo(PropertyInfo propertyInfo)
    {
        this.SourceName = propertyInfo.Name;
        this.SourceType = propertyInfo.PropertyType;
    }

    /// <inheritdoc/>
    public virtual void SetComponent<TComponent>(Action<TComponent> componentAction = null)
        where TComponent : EmComponent, new()
    {
        this.InitializeComponent(componentAction);
    }

    /// <inheritdoc/>
    public void SetDefaultComponent(IEmPagesOptions options)
    {
        EmComponent component = this.DefaultComponent;
        var sourceType = this.SourceType.GetTypeByIgnoreTheNullable();
        if (sourceType != null && options.DefaultTypesToComponentsMapping.ContainsKey(sourceType))
        {
            var componentTypes = options.DefaultTypesToComponentsMapping[sourceType];
            switch (component.Type)
            {
                case ComponentType.Renderer:
                default:
                    component = Activator.CreateInstance(componentTypes.Renderer) as EmRenderer;
                    break;
                case ComponentType.Mutator:
                    component = Activator.CreateInstance(componentTypes.Mutator) as EmMutator;
                    break;
            }

            if (component == null)
            {
                throw new EmSetupException($"Framework cannot create a component instance for primitive of type {sourceType}");
            }
        }

        this.Component = component;
        this.Component.SourceType = this.SourceType;
        this.Parameters = this.Component.GetParametersObject();
        this.Component.ValidateSetup();
    }

    /// <summary>
    /// Initialize component and its specified properties.
    /// </summary>
    /// <param name="componentAction"></param>
    /// <param name="postConfigurationComponentAction"></param>
    /// <typeparam name="TComponent">Type of the component.</typeparam>
    protected void InitializeComponent<TComponent>(
        Action<TComponent> componentAction,
        Action<TComponent> postConfigurationComponentAction = null)
        where TComponent : EmComponent, new()
    {
        var component = new TComponent();
        componentAction?.Invoke(component);
        this.Component = component;
        this.Component.SourceType = this.SourceType;
        postConfigurationComponentAction?.Invoke(component);
        this.Parameters = this.Component.GetParametersObject();
        this.Component.ValidateSetup();
    }
}