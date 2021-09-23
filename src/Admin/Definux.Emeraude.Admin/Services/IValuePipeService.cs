using System.Collections.Generic;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Services
{
    /// <summary>
    /// Service for extraction and applying value pipes to values.
    /// </summary>
    public interface IValuePipeService
    {
        /// <summary>
        /// Apply value pipes of the specified entity model.
        /// </summary>
        /// <param name="models"></param>
        /// <typeparam name="TEntityModel">Type of the entity model.</typeparam>
        /// <returns></returns>
        Task ApplyValuePipesAsync<TEntityModel>(IEnumerable<TEntityModel> models);
    }
}