using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Files
{
    /// <summary>
    /// Service that manages the project structure folders of the application.
    /// </summary>
    public interface IFoldersInitializer
    {
        /// <summary>
        /// Creates all folders that don't exist in the application.
        /// </summary>
        /// <returns></returns>
        Task InitFoldersAsync();
    }
}