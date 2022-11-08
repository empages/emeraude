using System;
using Microsoft.AspNetCore.Identity;

namespace EmPages.Identity.Entities;

/// <summary>
/// <inheritdoc cref="IdentityUserToken{TKey}"/>
/// </summary>
internal class EmIdentityUserToken : IdentityUserToken<Guid>
{
}