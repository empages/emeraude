namespace EmPages.Pages;

/// <summary>
/// Abstract implementation of component.
/// </summary>
public abstract class EmComponent
{
    private EmType propertyType;

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
    public string Name => this.GetType().Name;

    /// <summary>
    /// Type of the component.
    /// </summary>
    public ComponentType Type { get; }

    /// <summary>
    /// Type of the property that is using the component.
    /// </summary>
    public EmType PropertyType
    {
        get => this.propertyType;
        set
        {
            this.propertyType = value;
            this.OnAfterPropertyTypeIsSet(value);
        }
    }

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
    /// Event that will be invoked when the property type is set.
    /// </summary>
    /// <param name="type"></param>
    protected virtual void OnAfterPropertyTypeIsSet(EmType type)
    {
    }
}