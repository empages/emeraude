using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed
{
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
}
