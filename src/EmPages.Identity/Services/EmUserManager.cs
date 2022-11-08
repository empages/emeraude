using System;
using System.Collections.Generic;
using EmPages.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace EmPages.Identity.Services;

/// <inheritdoc />
internal class EmUserManager : UserManager<EmIdentityUser>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmUserManager"/> class.
    /// </summary>
    /// <param name="store"></param>
    /// <param name="options"></param>
    /// <param name="passwordHasher"></param>
    /// <param name="userValidators"></param>
    /// <param name="passwordValidators"></param>
    /// <param name="keyNormalizer"></param>
    /// <param name="errors"></param>
    /// <param name="services"></param>
    /// <param name="logger"></param>
    public EmUserManager(
        IUserStore<EmIdentityUser> store,
        IEmIdentityOptions options,
        IPasswordHasher<EmIdentityUser> passwordHasher,
        IEnumerable<IUserValidator<EmIdentityUser>> userValidators,
        IEnumerable<IPasswordValidator<EmIdentityUser>> passwordValidators,
        ILookupNormalizer keyNormalizer,
        IdentityErrorDescriber errors,
        IServiceProvider services,
        ILogger<EmUserManager> logger)
        : base(
            store,
            Microsoft.Extensions.Options.Options.Create(options.IdentityOptions),
            passwordHasher,
            userValidators,
            passwordValidators,
            keyNormalizer,
            errors,
            services,
            logger)
    {
    }
}