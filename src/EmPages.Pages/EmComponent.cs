namespace EmPages.Pages;

/// <summary>
/// Abstract implementation of component.
/// </summary>
public abstract class EmComponent
{
    private EmType sourceType;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmComponent"/> class.
    /// </summary>
    /// <param name="type"></param>
    protected EmComponent(ComponentType type)
    {
        this.Type = type;
    }

    /// <summary>
    /// Name of the component in the UI provider source.
    /// </summary>
    public string SourceName => this.GetType().Name;

    /// <summary>
    /// Type of the component.
    /// </summary>
    public ComponentType Type { get; }

    /// <summary>
    /// Type of the source.
    /// </summary>
    public EmType SourceType
    {
        get => this.sourceType;
        set
        {
            this.sourceType = value;
            this.OnAfterSourceTypeIsSet(value);
        }
    }

    /// <summary>
    /// Full name of the source type.
    /// </summary>
    public string SourceTypeName => this.SourceType?.SourceType.FullName;

    /// <summary>
    /// Flag that indicates whether the source type is nullable or not.
    /// </summary>
    public bool IsNullable => this.SourceType?.IsNullable ?? false;

    /// <summary>
    /// Gets parameters object based on the component.
    /// </summary>
    /// <returns></returns>
    public virtual object GetParametersObject() => new { };

    /// <summary>
    /// Validates setup of component. In order to provide a custom implementation for the component
    /// take into account that there is no base implementation of that validation method.
    /// </summary>
    public virtual void ValidateSetup()
    {
    }

    /// <summary>
    /// Event that will be invoked when the source type is set.
    /// </summary>
    /// <param name="type"></param>
    protected virtual void OnAfterSourceTypeIsSet(EmType type)
    {
    }
}