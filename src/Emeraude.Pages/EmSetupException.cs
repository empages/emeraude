using System;

namespace Emeraude.Pages;

/// <summary>
/// Framework exception for invalid setup during model, schema or data definition.
/// </summary>
public class EmSetupException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmSetupException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public EmSetupException(string message)
        : base(message)
    {
    }
}