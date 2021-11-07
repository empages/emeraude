using System;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Infrastructure.Identity.Entities
{
    /// <summary>
    /// Role claim entity used from the application that implements ASP.NET Core <see cref="IdentityRoleClaim{TKey}"/>.
    /// </summary>
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
    }
}
