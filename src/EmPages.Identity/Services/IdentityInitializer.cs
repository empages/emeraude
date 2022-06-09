using System.Threading.Tasks;
using EmPages.Identity.Entities;

namespace EmPages.Identity.Services;

/// <inheritdoc />
internal class IdentityInitializer : IEmIdentityInitializer
{
    private readonly IdentityContext identityContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityInitializer"/> class.
    /// </summary>
    /// <param name="identityContext"></param>
    public IdentityInitializer(IdentityContext identityContext)
    {
        this.identityContext = identityContext;
    }

    /// <inheritdoc/>
    public async Task InitializeAsync()
    {
        await this.identityContext.Database.EnsureCreatedAsync();
    }
}