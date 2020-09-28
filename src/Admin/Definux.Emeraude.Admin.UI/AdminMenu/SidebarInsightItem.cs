using Newtonsoft.Json;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    public class SidebarInsightItem
    {
        [JsonProperty("route")]
        public string Route { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("isButton")]
        public bool IsButton { get; set; }

        [JsonProperty("blank")]
        public bool Blank { get; set; }
    }
}
