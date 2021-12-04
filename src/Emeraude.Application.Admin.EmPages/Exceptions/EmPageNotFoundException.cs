using System;

namespace Emeraude.Application.Admin.EmPages.Exceptions;

/// <summary>
/// Exception that is thrown when there is an attempt to a not found page.
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