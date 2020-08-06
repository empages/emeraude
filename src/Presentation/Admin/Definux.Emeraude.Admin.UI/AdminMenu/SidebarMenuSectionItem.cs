using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    public class SidebarMenuSectionItem : SidebarNavigationLinkItem
    {
        [JsonProperty("single")]
        public bool Single { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("children")]
        public List<SidebarNavigationLinkItem> Children { get; set; }
        
        public List<string> Controllers 
        { 
            get 
            {
                List<string> controllers = Children?.Select(x => x.Controller).ToList() ?? new List<string>();
                List<string> subControllers = new List<string>();
                Children?
                    .Where(x => x.SubControllers != null && x.SubControllers.Length > 0)
                    .Select(x => x.SubControllers.Select(y => y.ToLower()).ToList())
                    .ToList()
                    .ForEach(x => subControllers.AddRange(x));
                controllers.AddRange(subControllers);

                return controllers;
            } 
        }
    }
}
