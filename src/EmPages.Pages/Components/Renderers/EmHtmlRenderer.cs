namespace EmPages.Pages.Components.Renderers;

/// <summary>
/// Renderer for HTML.
/// </summary>
public class EmHtmlRenderer : EmRenderer
{
    /// <summary>
    /// Flag that indicates whether the HTML is encoded or not.
    /// </summary>
    public bool Encoded { get; set; }

    /// <inheritdoc/>
    public override object GetParametersObject() => new
    {
        this.Encoded,
    };
}