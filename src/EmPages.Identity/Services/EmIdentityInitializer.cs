using System.Linq;
using System.Threading.Tasks;
using EmPages.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EmPages.Identity.Services;

/// <inheritdoc />
internal class EmIdentityInitializer : IEmIdentityInitializer
{
    private const string DefaultUserEmail = "admin@example.com";

    private readonly EmIdentityContext identityContext;
    private readonly EmUserManager userManager;
    private readonly IEmIdentityOptions identityOptions;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmIdentityInitializer"/> class.
    /// </summary>
    /// <param name="identityContext"></param>
    /// <param name="userManager"></param>
    /// <param name="identityOptions"></param>
    public EmIdentityInitializer(
        EmIdentityContext identityContext,
        EmUserManager userManager,
        IEmIdentityOptions identityOptions)
    {
        this.identityContext = identityContext;
        this.userManager = userManager;
        this.identityOptions = identityOptions;
    }

    /// <inheritdoc/>
    public async Task InitializeAsync()
    {
        await this.identityContext.Database.EnsureCreatedAsync();

        if (!await this.identityContext.Users.AnyAsync())
        {
            await this.userManager.CreateAsync(
                new EmIdentityUser
                {
                    Email = DefaultUserEmail,
                    UserName = DefaultUserEmail,
                },
                this.identityOptions.DefaultUserPassword);
        }
    }
}