using System;
using System.Collections.Generic;

namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate dates.
/// </summary>
public class EmDateMutator : EmMutator
{
    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.SourceType.Group == TypeGroup.DateTimes && this.SourceType.SourceType != typeof(DateOnly))
        {
            throw new EmSetupException("DateMutator supports only source of type DateOnly.");
        }
    }
}