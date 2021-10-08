namespace Definux.Emeraude.Admin.UI.Models
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

        /// <summary>
        /// Indicates whether the title of the breadcrumb is using placeholder or not.
        /// </summary>
        public bool IsUsingPlaceholder
            => !string.IsNullOrWhiteSpace(this.Title) &&
               this.Title.StartsWith("[[") &&
               this.Title.EndsWith("]]");
    }
}