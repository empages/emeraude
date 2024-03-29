﻿using System;
using System.Threading.Tasks;
using Emeraude.Contracts;

namespace Emeraude.Infrastructure.Identity.Services;

/// <summary>
/// Helper accessor service that provides the identity user for the current request.
/// </summary>
public interface ICurrentUserProvider
{
    /// <summary>
    /// Id of the current user.
    /// </summary>
    public Guid? CurrentUserId { get; }

    /// <summary>
    /// Returns current request user.
    /// </summary>
    /// <returns></returns>
    Task<IUser> GetCurrentUserAsync();
}