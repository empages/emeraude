using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Definux.Emeraude.Admin.EmPages.UI.Models.FormView;
using Definux.Emeraude.Admin.EmPages.UI.Models.TableView;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.UI.Adapters
{
    /// <summary>
    /// Data accessor and mutator of exposed data for purposes of EmPages.
    /// </summary>
    public interface IEmPageDataProvider
    {
        /// <summary>
        /// Retrieves EmPage table view data.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <param name="query"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        Task<EmPageTableViewData> RetrieveTableViewDataAsync(
            string entityKey,
            IDictionary<string, StringValues> query,
            EmPageTableViewSchema schema);

        /// <summary>
        /// Retrieves EmPage details view data.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <param name="entityId"></param>
        /// <param name="query"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        Task<EmPageDetailsViewData> RetrieveDetailsViewDataAsync(
            string entityKey,
            string entityId,
            IDictionary<string, StringValues> query,
            EmPageDetailsViewSchema schema);

        /// <summary>
        /// Retrieves EmPage form view data.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="entityKey"></param>
        /// <param name="entityId"></param>
        /// <param name="query"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        Task<EmPageFormViewData> RetrieveFormViewDataAsync(
            EmPageFormType type,
            string entityKey,
            string entityId,
            IDictionary<string, StringValues> query,
            EmPageFormViewSchema schema);
    }
}