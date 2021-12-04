using System;

namespace Emeraude.Contracts;

/// <summary>
/// Contract that represent the domain entity.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    Guid Id { get; set; }
}