using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators;

/// <summary>
/// Component that mutate dates.
/// </summary>
public class EmPageDateMutator : EmPageComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDateMutator"/> class.
    /// </summary>
    public EmPageDateMutator()
        : base(EmPageComponentType.Mutator)
    {
    }
}