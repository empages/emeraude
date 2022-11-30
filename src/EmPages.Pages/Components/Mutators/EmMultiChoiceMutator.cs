using System;
using System.Linq;
using Essentials.Extensions;

namespace EmPages.Pages.Components.Mutators;

/// <summary>
/// Component that mutate enumerations.
/// </summary>
public class EmMultiChoiceMutator : EmMutator
{
    /// <summary>
    /// Multi choice HTML type. Default is 'Select'.
    /// </summary>
    public MultiChoiceType MultiChoiceType { get; set; } = MultiChoiceType.Select;

    /// <summary>
    /// Id of the custom type assigned to that mutator.
    /// </summary>
    public string CustomTypeId { get; set; }

    /// <inheritdoc/>
    public override object GetParametersObject() => new
    {
        this.MultiChoiceType,
        this.CustomTypeId,
    };

    /// <inheritdoc/>
    public override void ValidateSetup()
    {
        if (this.MultiChoiceType == MultiChoiceType.CheckboxGroup && this.PropertyType.Group != TypeGroup.Arrays)
        {
            throw new EmSetupException($"Error configuring the component '{this.GetType().FullName}'. Cannot use MultiChoiceType.CheckboxGroup for non-iterable types.");
        }
    }

    /// <inheritdoc/>
    protected override void OnAfterPropertyTypeIsSet(EmType type)
    {
        if (type.IsEnum)
        {
            this.CustomTypeId = EmPageUtilities.GenerateTypeId(type.SourceType.FullName);
        }
    }
}