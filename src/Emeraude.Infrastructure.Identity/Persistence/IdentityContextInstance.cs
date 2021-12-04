using Microsoft.EntityFrameworkCore;

namespace Emeraude.Infrastructure.Identity.Persistence;

/// <summary>
/// Identity context instance.
/// </summary>
public class IdentityContextInstance : IdentityContext<IdentityContextInstance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityContextInstance"/> class.
    /// </summary>
    /// <param name="options"></param>
    public IdentityContextInstance(DbContextOptions<IdentityContextInstance> options)
        : base(options)
    {
    }
}