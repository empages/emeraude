using System;

namespace EmPages.Pages;

/// <summary>
/// Framework exception for invalid input from user requests.
/// </summary>
public class EmValidationException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmValidationException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public EmValidationException(string message)
        : base(message)
    {
    }
}