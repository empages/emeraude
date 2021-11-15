using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Schema;

namespace Emeraude.Application.Admin.EmPages.Services
{
    /// <summary>
    /// Main service for operations with EmPages.
    /// </summary>
    public interface IEmPageService
    {
        /// <summary>
        /// Finds registered schema description by the entity key of the schema.
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(string route);

        /// <summary>
        /// Finds registered schema description by the model type.
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(Type modelType);

        /// <summary>
        /// Finds registered schema description by the model type.
        /// The difference than <see cref="FindSchemaDescriptionAsync(Type)"/> is that method
        /// must be executed on places where the schema must be already defined because we assume schemas are already fetched.
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        EmPageSchemaDescription FindSchemaDescriptionByContract(Type modelType);

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