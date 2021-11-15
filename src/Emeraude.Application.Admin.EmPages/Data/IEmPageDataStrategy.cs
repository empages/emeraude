using Emeraude.Application.Admin.EmPages.Data.Requests;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Utilities;

namespace Emeraude.Application.Admin.EmPages.Data
{
    /// <summary>
    /// Contract for data strategy that defines the operations commands and queries of data manager that use the strategy.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageDataStrategy<TModel>
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Build raw model query.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IEmPageRequest<TModel> BuildRawModelQuery(EmPageDataFilter filter);

        /// <summary>
        /// Build raw model query.
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        IEmPageRequest<TModel> BuildRawModelQuery(string modelId);

        /// <summary>
        /// Build fetch query.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        IEmPageRequest<TModel> BuildFetchQuery(EmPageDataFetchQueryBody body);

        /// <summary>
        /// Build details query.
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        IEmPageRequest<TModel> BuildDetailsQuery(string modelId);

        /// <summary>
        /// Build create command.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        IEmPageRequest<TModel> BuildCreateCommand(TModel model);
    }
}