using System;
using Microsoft.AspNetCore.Identity;

namespace EmPages.Identity.Entities;

/// <summary>
/// <inheritdoc cref="IdentityUserLogin{TKey}"/>
/// </summary>
internal class UserLogin : IdentityUserLogin<Guid>
{
}