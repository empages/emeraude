namespace Emeraude.Pages;

/// <summary>
/// Abstract mutator.
/// </summary>
public abstract class EmMutator : EmComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmMutator"/> class.
    /// </summary>
    protected EmMutator()
        : base(ComponentType.Mutator)
    {
    }
}