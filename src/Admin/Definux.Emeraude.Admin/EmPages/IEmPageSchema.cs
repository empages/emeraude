using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.EmPages
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
        /// <param name="context"></param>
        /// <returns></returns>
        Task<EmPageSchemaSettings<TModel>> SetupAsync(EmPageSchemaContext context);
    }
}