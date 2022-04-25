using System;

namespace Emeraude.Pages;

/// <summary>
/// Framework exception for missing page.
/// </summary>
public class EmPageNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageNotFoundException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public EmPageNotFoundException(string message)
        : base(message)
    {
    }
}