using Newtonsoft.Json;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    /// <summary>
    /// Model defines the sidebar insight item.
    /// </summary>
    public class SidebarInsightItem
    {
        /// <summary>
        /// Route of the item.
        /// </summary>
        [JsonProperty("route")]
        public string Route { get; set; }

        /// <summary>
        /// Title of the item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Icon of the item.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Indicates whether the item has button behavior or not.
        /// </summary>
        [JsonProperty("isButton")]
        public bool IsButton { get; set; }

        /// <summary>
        /// Flag that indicates whether the route be opened on the same page or not.
        /// </summary>
        [JsonProperty("blank")]
        public bool Blank { get; set; }
    }
}
