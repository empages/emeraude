using System;
using System.Reflection;
using EmPages.Pages.Components;
using EmPages.Pages.Components.Mutators;
using EmPages.Pages.Components.Renderers;

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
    public virtual EmComponent DefaultComponent => new EmTextRenderer();

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
    public void SetDefaultComponent()
    {
        EmComponent component = this.DefaultComponent;
        var propertyType = new EmType(this.SourceType);
        if (EmComponentsDefaults.DefaultTypesToComponentsMapping.ContainsKey(propertyType.SourceType) && !propertyType.IsEnum && !propertyType.IsEnumerable)
        {
            var componentTypes = EmComponentsDefaults.DefaultTypesToComponentsMapping[propertyType.SourceType];
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
                throw new EmSetupException($"Framework cannot create a component instance for primitive of type {propertyType}");
            }
        }

        if (propertyType.IsEnum)
        {
            switch (component.Type)
            {
                case ComponentType.Renderer:
                default:
                    if (propertyType.IsEnumerable)
                    {
                        break;
                    }

                    component = new EmEnumRenderer();
                    break;
                case ComponentType.Mutator:
                    var mutator = new EmMultiChoiceMutator();
                    if (propertyType.IsEnumerable)
                    {
                        mutator.MultiChoiceType = MultiChoiceType.CheckboxGroup;
                    }

                    component = mutator;

                    break;
            }
        }

        this.Component = component;
        this.Component.PropertyType = new EmType(this.SourceType);
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
        this.Component.PropertyType = new EmType(this.SourceType);
        postConfigurationComponentAction?.Invoke(component);
        this.Parameters = this.Component.GetParametersObject();
        this.Component.ValidateSetup();
    }
}