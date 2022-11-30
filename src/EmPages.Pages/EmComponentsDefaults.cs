using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EmPages.Pages.Components.Mutators;
using EmPages.Pages.Components.Renderers;

namespace EmPages.Pages;

/// <summary>
/// Internal static defaults for the needs of Emerald Pages.
/// </summary>
public static class EmComponentsDefaults
{
    /// <summary>
    /// Default map between types and components.
    /// </summary>
    internal static readonly IReadOnlyDictionary<Type, (Type Renderer, Type Mutator)> DefaultTypesToComponentsMapping =
        new ReadOnlyDictionary<Type, (Type Renderer, Type Mutator)>(new Dictionary<Type, (Type Renderer, Type Mutator)>
    {
        { typeof(string), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(char), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(bool), (typeof(EmFlagRenderer), typeof(EmFlagMutator)) },
        { typeof(sbyte), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(byte), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(short), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(ushort), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(int), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(uint), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(long), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(ulong), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(float), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(double), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(decimal), (typeof(EmTextRenderer), typeof(EmTextMutator)) },
        { typeof(DateOnly), (typeof(EmTextRenderer), typeof(EmDateMutator)) },
        { typeof(TimeOnly), (typeof(EmTextRenderer), typeof(EmTimeMutator)) },
        { typeof(DateTime), (typeof(EmTextRenderer), typeof(EmDateTimeMutator)) },
    });
}