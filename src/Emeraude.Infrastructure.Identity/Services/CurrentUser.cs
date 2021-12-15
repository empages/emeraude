using System;
using Emeraude.Essentials.Extensions;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Infrastructure.Identity.Services;

/// <inheritdoc />
public class CurrentUser : ICurrentUser
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentUser"/> class.
    /// </summary>
    /// <param name="httpContextAccessor"></param>
    public CurrentUser(IHttpContextAccessor httpContextAccessor)
    {
        this.Id = httpContextAccessor.GetCurrentUserId() ?? httpContextAccessor.HttpContext.GetJwtUserId();
    }

    /// <inheritdoc/>
    public Guid? Id { get; }
}