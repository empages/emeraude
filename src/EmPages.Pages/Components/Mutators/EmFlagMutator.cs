namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate booleans.
/// </summary>
public class EmFlagMutator : EmMutator
{
    /// <summary>
    /// Text that will be visualized for true option. The default is 'Yes'.
    /// </summary>
    public string TrueText { get; set; } = "Yes";

    /// <summary>
    /// Text that will be visualized for false option. The default is 'No'.
    /// </summary>
    public string FalseText { get; set; } = "No";

    /// <inheritdoc/>
    public override object GetParametersObject() => new
    {
        this.TrueText,
        this.FalseText,
    };

    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.PropertyType.SourceType != typeof(bool))
        {
            throw new EmSetupException("FlagMutator supports only source of type bool.");
        }
    }
}