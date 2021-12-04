using System;

namespace Emeraude.Application.Exceptions;

/// <summary>
/// Custom exception design for requests that access entity that not exist or not available.
/// </summary>
public class EntityNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityNotFoundException"/> class.
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="identifier"></param>
    public EntityNotFoundException(string entity, Guid identifier)
        : base($"{entity} with id {identifier} have not been found.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EntityNotFoundException"/> class.
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="identifier"></param>
    public EntityNotFoundException(string entity, int identifier)
        : base($"{entity} with id {identifier} have not been found.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EntityNotFoundException"/> class.
    /// </summary>
    /// <param name="message"></param>
    public EntityNotFoundException(string message)
        : base(message)
    {
    }
}