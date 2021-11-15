using System;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Infrastructure.Identity.Entities
{
    /// <summary>
    /// User token entity used from the application that implements ASP.NET Core <see cref="IdentityUserToken{TKey}"/>.
    /// </summary>
    public class UserToken : IdentityUserToken<Guid>
    {
    }
}
