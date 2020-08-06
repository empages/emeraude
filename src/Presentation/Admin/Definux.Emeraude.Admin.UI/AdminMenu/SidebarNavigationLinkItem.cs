using Newtonsoft.Json;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    public class SidebarNavigationLinkItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("controller")]
        public string Controller { get; set; }

        [JsonProperty("subControllers")]
        public string[] SubControllers { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("routeValues")]
        public Dictionary<string, object> RouteValues { get; set; }
    }
}
