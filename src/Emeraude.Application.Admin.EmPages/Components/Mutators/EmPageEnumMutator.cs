﻿using System;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Essentials.Extensions;
using Emeraude.Essentials.Helpers;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators;

/// <summary>
/// Component that mutate enumerations.
/// </summary>
public class EmPageEnumMutator : EmPageComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageEnumMutator"/> class.
    /// </summary>
    public EmPageEnumMutator()
        : base(EmPageComponentType.Mutator)
    {
    }

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
            throw new EmPageInvalidSchemaDefinitionException($"Error configuring the component '{this.GetType().FullName}'. Cannot use MultiChoiceType.CheckboxGroup for non-iterable types.");
        }
    }
}