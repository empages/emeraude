using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.UI.Utilities;
using Newtonsoft.Json;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    /// <summary>
    /// Model that defines sidebar link part of the sidebar section <see cref="SidebarMenuSectionItem"/>.
    /// </summary>
    public class SidebarNavigationLinkItem
    {
        /// <summary>
        /// Title of the link item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Route of the link item.
        /// </summary>
        [JsonProperty("routes")]
        public List<string> Routes { get; set; }

        /// <summary>
        /// Default route of the link item.
        /// </summary>
        public string DefaultRoute => this.Routes?.FirstOrDefault() ?? "#";

        /// <summary>
        /// Flag that indicates the active state of the link item.
        /// </summary>
        public bool IsActive { get; protected set; }

        /// <summary>
        /// Method that apply current route to the state of the navigation link.
        /// </summary>
        /// <param name="currentRoute"></param>
        public virtual void BuildState(string currentRoute)
        {
            if (this.Routes != null && this.Routes.Count > 0)
            {
                for (int i = 0; i < this.Routes.Count; i++)
                {
                    this.Routes[i] = Functions.NormalizeRoute(this.Routes[i]);
                }

                this.IsActive = this.Routes.Contains(Functions.NormalizeRoute(currentRoute));

                if (!this.IsActive)
                {
                    foreach (var route in this.Routes)
                    {
                        string normalizedRoute = Functions.NormalizeRoute(route);
                        if (normalizedRoute.EndsWith("{*}") && currentRoute.StartsWith(normalizedRoute.Substring(0, normalizedRoute.Length - 3)))
                        {
                            this.IsActive = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
