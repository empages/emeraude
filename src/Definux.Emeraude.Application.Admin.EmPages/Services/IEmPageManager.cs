using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Admin.EmPages.Models.DetailsView;
using Definux.Emeraude.Application.Admin.EmPages.Models.FormView;
using Definux.Emeraude.Application.Admin.EmPages.Models.TableView;
using Definux.Emeraude.Application.Admin.EmPages.Shared;
using Definux.Emeraude.Application.Admin.EmPages.Utilities;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Application.Admin.EmPages.Services
{
    /// <summary>
    /// Schema and data accessor and mutator of exposed data for purposes of EmPages.
    /// </summary>
    public interface IEmPageManager
    {
        /// <summary>
        /// Retrieves table view model.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="query"></param>
        /// <param name="filter"></param>
        /// <param name="featureMode"></param>
        /// <returns></returns>
        Task<EmPageTableViewModel> RetrieveTableViewModelAsync(
            string route,
            IDictionary<string, StringValues> query,
            EmPageDataFilter filter = null,
            bool featureMode = false);

        /// <summary>
        /// Retrieves details view model.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="modelId"></param>
        /// <param name="query"></param>
        /// <param name="filter"></param>
        /// <param name="featureMode"></param>
        /// <returns></returns>
        Task<EmPageDetailsViewModel> RetrieveDetailsViewModelAsync(
            string route,
            string modelId,
            IDictionary<string, StringValues> query,
            EmPageDataFilter filter = null,
            bool featureMode = false);

        /// <summary>
        /// Retrieves table view model for the context of feature.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<EmPageTableViewModel> RetrieveFeatureTableViewModelAsync(
            EmPageDetailsFeatureModel feature,
            IDictionary<string, StringValues> query);

        /// <summary>
        /// Retrieves form view model.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="route"></param>
        /// <param name="modelId"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<EmPageFormViewModel> RetrieveFormViewModelAsync(
            EmPageFormType type,
            string route,
            string modelId,
            IDictionary<string, StringValues> query);

        /// <summary>
        /// Submit form view model for processing.
        /// </summary>
        /// <param name="formType"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task<EmPageFormSubmissionResponse> SubmitFormViewModelAsync(
            EmPageFormType formType,
            EmPageFormViewModel viewModel);
    }
}