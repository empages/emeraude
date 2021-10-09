using System;
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
        /// <param name="entityId"></param>
        /// <returns></returns>
        Task<IEmPageModel> GetRawModelAsync(Guid entityId);

        /// <summary>
        /// Fetch operation.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<TableViewDataRequestResult> FetchAsync(EmPageDataFetchQueryRequest request);

        /// <summary>
        /// Details operation.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<EmPageModelResponse> DetailsAsync(Guid id);

        /// <summary>
        /// Create operation.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<Guid?> CreateAsync(IEmPageModel model);
    }
}
