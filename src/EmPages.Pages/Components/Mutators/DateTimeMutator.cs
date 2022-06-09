using System;

namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate dates with times.
/// </summary>
public class DateTimeMutator : EmMutator
{
    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.SourceType != typeof(DateTime))
        {
            throw new EmSetupException("DateTimeMutator supports only source of type DateTime.");
        }
    }
}