namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Model defines the sidebar insight item.
    /// </summary>
    public class SidebarInsightItem
    {
        /// <summary>
        /// Route of the item.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Title of the item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Icon of the item.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Indicates whether the item has button behavior or not.
        /// </summary>
        public bool IsButton { get; set; }

        /// <summary>
        /// Flag that indicates whether the route be opened on the same page or not.
        /// </summary>
        public bool Blank { get; set; }
    }
}
