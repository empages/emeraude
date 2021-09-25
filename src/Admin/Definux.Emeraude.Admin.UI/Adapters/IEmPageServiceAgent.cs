using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.UI.Adapters
{
    /// <summary>
    /// Service accessor for fetch exposed data for purposes of admin entity models.
    /// </summary>
    public interface IEmPageServiceAgent
    {
        /// <summary>
        /// Retrieves entity table view data.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <param name="queryString"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        Task<EmPageTableViewData> RetrieveTableViewDataAsync(string entityKey, string queryString, EmPageTableViewSchema schema);
    }
}