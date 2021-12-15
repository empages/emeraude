using System;

namespace Emeraude.Infrastructure.Identity.Services;

/// <summary>
/// Current user accessor.
/// </summary>
public interface ICurrentUser
{
    /// <summary>
    /// Current user id.
    /// </summary>
    Guid? Id { get; }
}