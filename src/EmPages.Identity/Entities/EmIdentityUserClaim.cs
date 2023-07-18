﻿using System;
using Microsoft.AspNetCore.Identity;

namespace EmPages.Identity.Entities;

/// <summary>
/// <inheritdoc cref="IdentityUserClaim{TKey}"/>
/// </summary>
internal class EmIdentityUserClaim : IdentityUserClaim<Guid>
{
}