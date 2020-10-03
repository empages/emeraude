using System;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Identity.Entities
{
    /// <summary>
    /// User token entity used from the application that implements ASP.NET Core <see cref="IdentityUserToken{TKey}"/>.
    /// </summary>
    public class UserToken : IdentityUserToken<Guid>
    {
    }
}
