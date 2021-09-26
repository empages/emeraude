using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Main service for operations with EmPages.
    /// </summary>
    public interface IEmPageService
    {
        /// <summary>
        /// Finds registered schema description by the entity key of the schema.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(string key);

        /// <summary>
        /// Finds registered schema description by the entity and model types.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="modelType"></param>
        /// <returns></returns>
        Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(Type entityType, Type modelType);

        /// <summary>
        /// Apply value pipes of the specified entity model.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="viewItems"></param>
        /// <typeparam name="TEmPageModel">Type of the entity model.</typeparam>
        /// <returns></returns>
        Task ApplyValuePipesAsync<TEmPageModel>(IEnumerable<TEmPageModel> models, IEnumerable<IValuePipedViewItem> viewItems);
    }
}