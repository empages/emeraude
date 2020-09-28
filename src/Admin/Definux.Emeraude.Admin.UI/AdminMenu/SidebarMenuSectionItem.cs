using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    public class SidebarMenuSectionItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("children")]
        public List<SidebarNavigationLinkItem> Children { get; set; }

        [JsonProperty("dropdown")]
        public bool Dropdown { get; set; }

        public bool IsSingle => Children != null && Children.Count == 1;

        public SidebarNavigationLinkItem SingleLinkItem => IsSingle ? Children.FirstOrDefault() : null;

        public bool IsActive => Children.Any(x => x.IsActive);

        public virtual void BuildState(string currentRoute)
        {
            if (Children != null && Children.Count > 0)
            {
                foreach (var child in Children)
                {
                    child.BuildState(currentRoute);
                }

                if (Children.Count > 1)
                {
                    Dropdown = true;
                }
            }
        }
    }
}
