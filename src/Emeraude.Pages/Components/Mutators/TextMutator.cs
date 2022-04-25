﻿namespace Emeraude.Pages.Components.Mutators;

/// <summary>
/// Component that mutate texts.
/// </summary>
public class TextMutator : EmMutator
{
    /// <summary>
    /// Flag that indicates whether the text is large or not.
    /// </summary>
    public bool LargeText { get; set; }

    /// <inheritdoc/>
    public override object GetParametersObject() => new
    {
        this.LargeText,
    };
}