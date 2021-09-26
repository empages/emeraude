using System.Threading.Tasks;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Contract for EmPages schemas.
    /// </summary>
    /// <typeparam name="TEntity">Domain entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageSchema<TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Configures all features and utilities of the current schema.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        Task<EmPageSchemaSettings<TEntity, TModel>> SetupAsync(EmPageSchemaContext context);
    }
}