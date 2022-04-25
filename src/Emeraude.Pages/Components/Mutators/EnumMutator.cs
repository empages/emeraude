using Essentials.Extensions;

namespace Emeraude.Pages.Components.Mutators;

/// <summary>
/// Component that mutate enumerations.
/// </summary>
public class EnumMutator : EmMutator
{
    /// <summary>
    /// Multi choice HTML type. Default is 'Select'.
    /// </summary>
    public MultiChoiceType MultiChoiceType { get; set; } = MultiChoiceType.Select;

    /// <inheritdoc/>
    public override object GetParametersObject() => new
    {
        this.MultiChoiceType,
    };

    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.MultiChoiceType == MultiChoiceType.CheckboxGroup && !this.SourceType.IsIterableType())
        {
            throw new EmSetupException($"Error configuring the component '{this.GetType().FullName}'. Cannot use MultiChoiceType.CheckboxGroup for non-iterable types.");
        }
    }
}