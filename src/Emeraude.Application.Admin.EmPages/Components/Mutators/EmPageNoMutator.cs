using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators;

/// <summary>
/// Component that place the value of the model into a hidden input.
/// </summary>
public class EmPageNoMutator : EmPageComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageNoMutator"/> class.
    /// </summary>
    public EmPageNoMutator()
        : base(EmPageComponentType.Mutator)
    {
    }
}