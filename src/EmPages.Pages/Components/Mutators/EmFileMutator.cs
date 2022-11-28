namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate files.
/// </summary>
public class EmFileMutator : EmMutator
{
    /// <summary>
    /// Destination folder for saving the files.
    /// </summary>
    public string DestinationFolder { get; set; }

    /// <inheritdoc/>
    public override object GetParametersObject() => new
    {
        this.DestinationFolder,
    };
}