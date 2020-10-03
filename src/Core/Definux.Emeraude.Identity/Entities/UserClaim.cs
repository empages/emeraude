using System;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Identity.Entities
{
    /// <summary>
    /// User claim entity used from the application that implements ASP.NET Core <see cref="IdentityUserClaim{TKey}"/>.
    /// </summary>
    public class UserClaim : IdentityUserClaim<Guid>
    {
    }
}
