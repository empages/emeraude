using System;

namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate time.
/// </summary>
public class EmTimeMutator : EmMutator
{
    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.PropertyType.Group == TypeGroup.DateTimes && this.PropertyType.SourceType != typeof(TimeOnly))
        {
            throw new EmSetupException("TimeMutator supports only source of type TimeOnly.");
        }
    }
}