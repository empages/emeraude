using System;

namespace Emeraude.Configuration.Exceptions;

/// <summary>
/// Exception thrown when some configuration is not set properly.
/// </summary>
public class EmInvalidConfigurationException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmInvalidConfigurationException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public EmInvalidConfigurationException(string message)
        : base(message)
    {
    }
}