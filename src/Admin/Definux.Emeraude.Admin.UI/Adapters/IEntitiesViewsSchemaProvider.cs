using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.UI.Adapters
{
    /// <summary>
    /// Adapter contract for providing entities views schema.
    /// </summary>
    public interface IEntitiesViewsSchemaProvider
    {
        /// <summary>
        /// Gets table view schema of specified entity.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <returns></returns>
        EntityTableViewSchema GetTableViewSchema(string entityKey);

        /// <summary>
        /// Gets details view schema of specified entity.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <returns></returns>
        EntityDetailsViewSchema GetDetailsViewSchema(string entityKey);

        /// <summary>
        /// Gets form view schema of specified entity.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <returns></returns>
        EntityFormViewSchema GetFormViewSchema(string entityKey);
    }
}