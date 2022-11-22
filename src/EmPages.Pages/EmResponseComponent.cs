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
        this.SourceName = component.SourceName;
        this.SourceTypeName = component.SourceTypeName;
        this.Type = component.Type;
        this.IsNullable = component.IsNullable;
        this.Parameters = component.GetParametersObject();
        this.Index = index;
    }

    /// <summary>
    /// Component index.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// <inheritdoc cref="EmComponent.SourceName"/>
    /// </summary>
    public string SourceName { get; }

    /// <summary>
    /// <inheritdoc cref="EmComponent.Type"/>
    /// </summary>
    public ComponentType Type { get; }

    /// <summary>
    /// <inheritdoc cref="EmComponent.SourceTypeName"/>
    /// </summary>
    public string SourceTypeName { get; }

    /// <summary>
    /// <inheritdoc cref="EmComponent.IsNullable"/>
    /// </summary>
    public bool IsNullable { get; }

    /// <summary>
    /// Parameters of the component.
    /// </summary>
    public object Parameters { get; }
}