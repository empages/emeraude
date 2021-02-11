using System;
using System.Collections.Generic;
using Definux.Utilities.Objects;

namespace Definux.Emeraude.Admin.UI.ViewModels.Logging
{
    /// <summary>
    /// Log entity abstraction for view model implementation.
    /// </summary>
    /// <typeparam name="TResultViewModel">Result view model implementation.</typeparam>
    public class LogEntitiesViewModel<TResultViewModel> : PaginatedList<TResultViewModel>
    {
        /// <summary>
        /// Search query.
        /// </summary>
        public string SearchQuery { get; set; }

        /// <summary>
        /// Date indicates the start date of the filter.
        /// </summary>
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// Date indicates the end date of the filter.
        /// </summary>
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// User id or null used for filter by involved user.
        /// </summary>
        public string User { get; set; }
    }
}