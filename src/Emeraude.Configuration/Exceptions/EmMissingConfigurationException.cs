using System;

namespace Emeraude.Configuration.Exceptions;

/// <summary>
/// Exception thrown when some option contains missing required data.
/// </summary>
public class EmMissingConfigurationException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmMissingConfigurationException"/> class.
    /// </summary>
    public EmMissingConfigurationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmMissingConfigurationException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public EmMissingConfigurationException(string message)
        : base(message)
    {
    }
}