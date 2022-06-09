namespace EmPages.Pages;

/// <summary>
/// Abstract renderer.
/// </summary>
public class EmRenderer : EmComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmRenderer"/> class.
    /// </summary>
    protected EmRenderer()
        : base(ComponentType.Renderer)
    {
    }
}