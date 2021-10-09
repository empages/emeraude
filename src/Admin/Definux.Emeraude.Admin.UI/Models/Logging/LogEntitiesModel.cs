using Definux.Emeraude.Application.Models;
using Definux.Emeraude.Essentials.Models;

namespace Definux.Emeraude.Admin.UI.Models.Logging
{
    /// <summary>
    /// Log entity abstraction for model implementation.
    /// </summary>
    /// <typeparam name="TResultViewModel">Result model implementation.</typeparam>
    public class LogEntitiesModel<TResultViewModel> : PaginatedList<TResultViewModel>
    {
        /// <summary>
        /// Search query.
        /// </summary>
        public string SearchQuery { get; set; }

        /// <summary>
        /// Date indicates the start date of the filter.
        /// </summary>
        public DateModel? FromDate { get; set; }

        /// <summary>
        /// Date indicates the end date of the filter.
        /// </summary>
        public DateModel? ToDate { get; set; }

        /// <summary>
        /// User id or null used for filter by involved user.
        /// </summary>
        public string User { get; set; }
    }
}