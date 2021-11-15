namespace Emeraude.Application.Admin.Models
{
    /// <summary>
    /// Breadcrumb item model.
    /// </summary>
    public class BreadcrumbItemModel : LinkModel
    {
        /// <summary>
        /// Order of the action.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Flag that shows the active status of the breadcrumb.
        /// </summary>
        public bool IsActive { get; set; }
    }
}