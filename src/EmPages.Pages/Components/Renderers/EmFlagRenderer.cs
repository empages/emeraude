namespace EmPages.Pages.Components.Renderers;

/// <summary>
/// Renderer for booleans.
/// </summary>
public class EmFlagRenderer : EmRenderer
{
    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.PropertyType.SourceType != typeof(bool))
        {
            throw new EmSetupException("FlagRenderer supports only source of type bool.");
        }
    }
}