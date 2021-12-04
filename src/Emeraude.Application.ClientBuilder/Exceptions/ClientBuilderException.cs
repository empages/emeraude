using System;

namespace Emeraude.Application.ClientBuilder.Exceptions;

/// <summary>
/// Exception related to client builder.
/// </summary>
public class ClientBuilderException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientBuilderException"/> class.
    /// </summary>
    public ClientBuilderException()
        : base("An undefined client builder setup error occured.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ClientBuilderException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public ClientBuilderException(string message)
        : base(message)
    {
    }
}