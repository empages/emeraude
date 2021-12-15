using System;
using System.Threading.Tasks;
using Emeraude.Contracts;
using Emeraude.Essentials.Extensions;
using Emeraude.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.Identity.Services;

/// <inheritdoc cref="ICurrentUserProvider"/>
public class CurrentUserProvider : ICurrentUserProvider
{
    private readonly ICurrentUser currentUser;
    private readonly UserManager<User> userManager;
    private readonly ILogger<CurrentUserProvider> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentUserProvider"/> class.
    /// </summary>
    /// <param name="currentUser"></param>
    /// <param name="userManager"></param>
    /// <param name="logger"></param>
    public CurrentUserProvider(
        ICurrentUser currentUser,
        UserManager<User> userManager,
        ILogger<CurrentUserProvider> logger)
    {
        this.currentUser = currentUser;
        this.userManager = userManager;
        this.logger = logger;
    }

    /// <inheritdoc/>
    public Guid? CurrentUserId => this.currentUser.Id;

    /// <inheritdoc/>
    public async Task<IUser> GetCurrentUserAsync()
    {
        try
        {
            if (this.currentUser.Id.HasValue)
            {
                return await this.userManager.FindByIdAsync(this.currentUser.Id.Value.ToString());
            }

            return null;
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "An error occured during getting current user");
            return default;
        }
    }
}