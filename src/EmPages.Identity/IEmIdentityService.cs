﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmPages.Identity;

/// <summary>
/// Service that manages the identity users and their permissions in the framework.
/// </summary>
public interface IEmIdentityService
{
    /// <summary>
    /// Finds a user by ID.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<EmUserModel> FindUserAsync(Guid userId);

    /// <summary>
    /// Finds a user by email address.
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    Task<EmUserModel> FindUserAsync(string email);

    /// <summary>
    /// Fetch users by specified criteria.
    /// </summary>
    /// <param name="searchText"></param>
    /// <param name="skip"></param>
    /// <param name="take"></param>
    /// <returns></returns>
    Task<IEnumerable<EmUserModel>> FetchUsersAsync(string searchText, int skip, int take);

    /// <summary>
    /// Count users by specified criteria.
    /// </summary>
    /// <param name="searchText"></param>
    /// <returns></returns>
    Task<int> CountUsersAsync(string searchText);

    /// <summary>
    /// Retrieves access token from base credentials.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<EmAuthResult> RetrieveAccessTokenAsync(IEmTokenBaseCredentialsRequest request);

    /// <summary>
    /// Retrieves access token from MFA-based credentials.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<EmAuthResult> RetrieveAccessTokenAsync(IEmTokenMfaBasedCredentialsRequest request);
}