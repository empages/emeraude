using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Definux.Emeraude.Admin.EmPages.UI.Models.FormView;
using Definux.Emeraude.Admin.EmPages.UI.Models.TableView;

namespace Definux.Emeraude.Admin.EmPages.UI.Adapters
{
    /// <summary>
    /// Adapter contract for providing entities views schema.
    /// </summary>
    public interface IEmPageSchemaProvider
    {
        /// <summary>
        /// Gets table view schema of specified model.
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        Task<EmPageTableViewSchema> GetTableViewSchemaAsync(string route);

        /// <summary>
        /// Gets details view schema of specified model.
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        Task<EmPageDetailsViewSchema> GetDetailsViewSchemaAsync(string route);

        /// <summary>
        /// Gets form view schema of specified model.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        Task<EmPageFormViewSchema> GetFormViewSchemaAsync(EmPageFormType type, string route);
    }
}