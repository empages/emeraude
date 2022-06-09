using System;

namespace EmPages.Pages;

/// <summary>
/// Framework exception for missing command.
/// </summary>
public class EmNotRegisteredCommandException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmNotRegisteredCommandException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public EmNotRegisteredCommandException(string message)
        : base(message)
    {
    }
}