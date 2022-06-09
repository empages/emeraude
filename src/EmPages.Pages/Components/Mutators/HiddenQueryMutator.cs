namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate hidden values extracted from the query string.
/// </summary>
public class HiddenQueryMutator : EmMutator
{
    /// <summary>
    /// Key of the target query string param.
    /// </summary>
    public string ReferenceKey { get; set; }

    /// <inheritdoc/>
    public override object GetParametersObject() =>
        new
        {
            this.ReferenceKey,
        };
}