using System;
using System.Collections.Generic;

namespace Emeraude.Application.Admin.EmPages.Schema;

/// <summary>
/// Contract that provides value pipes transformation to the view item.
/// </summary>
public interface IValuePipedViewItem
{
    /// <summary>
    /// List of value pipes that must be applied to the item.
    /// </summary>
    IReadOnlyList<(Type, string[])> ValuePipes { get; }

    /// <summary>
    /// Adds value pipe to the value pipes list.
    /// </summary>
    /// <param name="parameters"></param>
    /// <typeparam name="TValuePipe">Value pipe type.</typeparam>
    void AddValuePipe<TValuePipe>(params string[] parameters)
        where TValuePipe : class, IValuePipe;
}