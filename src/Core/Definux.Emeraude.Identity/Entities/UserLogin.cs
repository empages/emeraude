using System;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Identity.Entities
{
    /// <summary>
    /// User login entity used from the application that implements ASP.NET Core <see cref="IdentityUserLogin{TKey}"/>.
    /// </summary>
    public class UserLogin : IdentityUserLogin<Guid>
    {
    }
}
