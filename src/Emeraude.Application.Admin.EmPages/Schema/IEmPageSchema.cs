using System.Threading.Tasks;

namespace Emeraude.Application.Admin.EmPages.Schema
{
    /// <summary>
    /// Contract for EmPages schemas.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageSchema<TModel>
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Configures all features and utilities of the current schema.
        /// </summary>
        /// <returns></returns>
        Task<EmPageSchemaSettings<TModel>> SetupAsync();
    }
}