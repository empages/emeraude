using System;

namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate dates with times.
/// </summary>
public class EmDateTimeMutator : EmMutator
{
    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.SourceType.Group == TypeGroup.DateTimes && this.SourceType.SourceType != typeof(DateTime))
        {
            throw new EmSetupException("DateTimeMutator supports only source of type DateTime.");
        }
    }
}