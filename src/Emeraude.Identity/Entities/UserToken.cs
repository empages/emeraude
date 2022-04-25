using System;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Identity.Entities;

/// <summary>
/// <inheritdoc cref="IdentityUserToken{TKey}"/>
/// </summary>
internal class UserToken : IdentityUserToken<Guid>
{
}