using System;
using System.Reflection;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Definux.Emeraude.Admin.EmPages.Schema;

namespace Definux.Emeraude.Admin.EmPages.Data
{
    /// <summary>
    /// Data manager that provides access to all data requests of EmPages.
    /// </summary>
    public interface IEmPageDataManager
    {
        /// <summary>
        /// Get instance of EmPage model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        Task<IEmPageModel> GetRawModelAsync(string modelId);

        /// <summary>
        /// Get instance of EmPage model.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<IEmPageModel> GetRawModelAsync(EmPageDataFilter filter);

        /// <summary>
        /// Fetch operation.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<TableViewDataRequestResult> FetchAsync(EmPageDataFetchQueryBody request);

        /// <summary>
        /// Details operation.
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        Task<EmPageModelResponse> DetailsAsync(string modelId);

        /// <summary>
        /// Create operation.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<string> CreateAsync(IEmPageModel model);
    }
}
