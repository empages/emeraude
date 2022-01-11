using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators;

/// <summary>
/// Component that mutate hidden values extracted from the query string.
/// </summary>
public class EmPageHiddenQueryMutator : EmPageComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageHiddenQueryMutator"/> class.
    /// </summary>
    public EmPageHiddenQueryMutator()
        : base(EmPageComponentType.Mutator)
    {
    }

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