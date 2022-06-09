namespace EmPages.Pages.Components.Renderers;

/// <summary>
/// Renderer for booleans.
/// </summary>
public class FlagRenderer : EmRenderer
{
    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.SourceType != typeof(bool))
        {
            throw new EmSetupException("FlagRenderer supports only source of type bool.");
        }
    }
}