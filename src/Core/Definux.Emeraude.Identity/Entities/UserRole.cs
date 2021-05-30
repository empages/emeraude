using System;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Identity.Entities
{
    /// <summary>
    /// User role entity used from the application that implements ASP.NET Core <see cref="IdentityUserRole{TKey}"/>.
    /// </summary>
    public class UserRole : IdentityUserRole<Guid>
    {
    }
}
