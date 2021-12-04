using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators;

/// <summary>
/// Component that mutate files.
/// </summary>
public class EmPageFileMutator : EmPageComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageFileMutator"/> class.
    /// </summary>
    public EmPageFileMutator()
        : base(EmPageComponentType.Mutator)
    {
    }

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