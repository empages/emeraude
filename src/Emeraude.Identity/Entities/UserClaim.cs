﻿using System;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Identity.Entities;

/// <summary>
/// <inheritdoc cref="IdentityUserClaim{TKey}"/>
/// </summary>
internal class UserClaim : IdentityUserClaim<Guid>
{
}