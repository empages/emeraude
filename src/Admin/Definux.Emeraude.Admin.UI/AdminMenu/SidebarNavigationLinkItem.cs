using Definux.Emeraude.Admin.UI.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    public class SidebarNavigationLinkItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("routes")]
        public List<string> Routes { get; set; }

        public string DefaultRoute => Routes?.FirstOrDefault() ?? "#";

        public bool IsActive { get; protected set; }

        public virtual void BuildState(string currentRoute)
        {
            if (Routes != null && Routes.Count > 0)
            {
                for (int i = 0; i < Routes.Count; i++)
                {
                    Routes[i] = Functions.NormalizeRoute(Routes[i]);
                }

                IsActive = Routes.Contains(Functions.NormalizeRoute(currentRoute));

                if (!IsActive)
                {
                    foreach (var route in Routes)
                    {
                        string normalizedRoute = Functions.NormalizeRoute(route);
                        if (normalizedRoute.EndsWith("{*}") && currentRoute.StartsWith(normalizedRoute.Substring(0, normalizedRoute.Length - 3)))
                        {
                            IsActive = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
