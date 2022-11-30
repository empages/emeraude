using EmPages.Pages.Components;

namespace EmPages.Pages;

/// <summary>
/// Transfer object for <see cref="EmComponent"/> required for the response models.
/// </summary>
public class EmResponseComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmResponseComponent"/> class.
    /// </summary>
    /// <param name="component"></param>
    /// <param name="index"></param>
    public EmResponseComponent(EmComponent component, int index)
    {
        this.SourceName = component.Name;
        this.Type = component.Type;
        this.PropertyTypeGroup = component.PropertyType.Group;
        this.IsNullable = component.PropertyType.IsNullable;
        this.Parameters = component.GetParametersObject();
        this.Index = index;
    }

    /// <summary>
    /// Component index.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// <inheritdoc cref="EmComponent.Name"/>
    /// </summary>
    public string SourceName { get; }

    /// <summary>
    /// <inheritdoc cref="EmComponent.Type"/>
    /// </summary>
    public ComponentType Type { get; }

    /// <summary>
    /// Group of the property type.
    /// </summary>
    public TypeGroup PropertyTypeGroup { get; set; }

    /// <summary>
    /// Flag that indicates whether the component supports nulls or not.
    /// </summary>
    public bool IsNullable { get; }

    /// <summary>
    /// Parameters of the component.
    /// </summary>
    public object Parameters { get; }
}