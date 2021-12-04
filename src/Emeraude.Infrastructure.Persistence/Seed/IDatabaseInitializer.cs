using System.Threading.Tasks;

namespace Emeraude.Infrastructure.Persistence.Seed;

/// <summary>
/// Definition of database initializer.
/// </summary>
public interface IDatabaseInitializer
{
    /// <summary>
    /// Seed the data into database for the current initializer.
    /// </summary>
    /// <returns></returns>
    Task SeedAsync();
}