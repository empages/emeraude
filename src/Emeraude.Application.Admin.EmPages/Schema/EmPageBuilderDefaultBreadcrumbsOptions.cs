using Emeraude.Application.Admin.EmPages.Utilities;

namespace Emeraude.Application.Admin.EmPages.Schema
{
    /// <summary>
    /// Defaults options used for applying default properties of schema settings.
    /// </summary>
    public class EmPageBuilderDefaultBreadcrumbsOptions
    {
        /// <summary>
        /// Table breadcrumb title. Default is null. If value is null, the title of the settings is used.
        /// </summary>
        public string TableBreadcrumbTitle { get; set; }

        /// <summary>
        /// Details breadcrumb title. Default is 'Details'
        /// </summary>
        public string DetailsBreadcrumbTitle { get; set; } = "Details";

        /// <summary>
        /// Form breadcrumb title. Default is <see cref="EmPagesPlaceholders.FormAction"/> placeholder.
        /// </summary>
        public string FormBreadcrumbTitle { get; set; } = EmPagesPlaceholders.FormAction;

        /// <summary>
        /// Breadcrumb title related to the current opened page. Mainly applicable for edit page.
        /// </summary>
        public string CurrentBreadcrumbTitle { get; set; } = "Current";
    }
}