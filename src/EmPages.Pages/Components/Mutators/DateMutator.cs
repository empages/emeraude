using System;
using System.Collections.Generic;

namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate dates.
/// </summary>
public class DateMutator : EmMutator
{
    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.SourceType != typeof(DateTime) || this.SourceType != typeof(DateOnly))
        {
            throw new EmSetupException("DateMutator supports only source of type DateTime or DateOnly.");
        }
    }
}