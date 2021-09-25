using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.UI.Adapters
{
    /// <summary>
    /// Adapter contract for providing entities views schema.
    /// </summary>
    public interface IEmPageSchemaProvider
    {
        /// <summary>
        /// Gets table view schema of specified entity.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <returns></returns>
        Task<EmPageTableViewSchema> GetTableViewSchemaAsync(string entityKey);

        /// <summary>
        /// Gets details view schema of specified entity.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <returns></returns>
        Task<EmPageDetailsViewSchema> GetDetailsViewSchemaAsync(string entityKey);

        /// <summary>
        /// Gets form view schema of specified entity.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <returns></returns>
        Task<EmPageFormViewSchema> GetFormViewSchemaAsync(string entityKey);
    }
}