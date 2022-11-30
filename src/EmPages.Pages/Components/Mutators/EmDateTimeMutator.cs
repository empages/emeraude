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
        if (this.PropertyType.Group == TypeGroup.DateTimes && this.PropertyType.SourceType != typeof(DateTime))
        {
            throw new EmSetupException("DateTimeMutator supports only source of type DateTime.");
        }
    }
}