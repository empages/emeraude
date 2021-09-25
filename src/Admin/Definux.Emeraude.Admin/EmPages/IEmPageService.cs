using System.Collections.Generic;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Main service for operations with EmPages.
    /// </summary>
    public interface IEmPageService
    {
        /// <summary>
        /// Finds register schema description by the entity key of the schema.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(string key);

        /// <summary>
        /// Apply value pipes of the specified entity model.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="viewType"></param>
        /// <typeparam name="TEmPageModel">Type of the entity model.</typeparam>
        /// <returns></returns>
        Task ApplyValuePipesAsync<TEmPageModel>(IEnumerable<TEmPageModel> models, ViewType viewType);
    }
}