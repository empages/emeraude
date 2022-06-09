using System;

namespace EmPages.Pages;

/// <summary>
/// Framework exception for missing model.
/// </summary>
public class EmModelNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmModelNotFoundException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public EmModelNotFoundException(string message)
        : base(message)
    {
    }
}