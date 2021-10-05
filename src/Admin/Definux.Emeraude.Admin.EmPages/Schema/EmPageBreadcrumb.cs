namespace Definux.Emeraude.Admin.EmPages.Schema
{
    /// <summary>
    /// Implementation class of page breadcrumb.
    /// </summary>
    public class EmPageBreadcrumb
    {
        /// <summary>
        /// Title of the breadcrumb.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Flag that indicates whether the breadcrumb is active or not.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Order of the breadcrumb.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Target href of the breadcrumb.
        /// </summary>
        public string Href { get; set; }
    }
}