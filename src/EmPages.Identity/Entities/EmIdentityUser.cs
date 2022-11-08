using System;
using Microsoft.AspNetCore.Identity;

namespace EmPages.Identity.Entities;

/// <summary>
/// <inheritdoc cref="IdentityUser{TKey}"/>
/// </summary>
internal class EmIdentityUser : IdentityUser<Guid>
{
}