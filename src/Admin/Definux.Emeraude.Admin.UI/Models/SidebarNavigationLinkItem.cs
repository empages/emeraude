using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Model that defines sidebar link part of the sidebar section <see cref="SidebarMenuSectionItem"/>.
    /// </summary>
    public class SidebarNavigationLinkItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SidebarNavigationLinkItem"/> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="routes"></param>
        public SidebarNavigationLinkItem(string title, params string[] routes)
        {
            this.Title = title;
            this.Routes = routes.ToList();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SidebarNavigationLinkItem"/> class.
        /// </summary>
        public SidebarNavigationLinkItem()
        {
        }

        /// <summary>
        /// Title of the link item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Route of the link item.
        /// </summary>
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
                    this.Routes[i] = NormalizeRoute(this.Routes[i]);
                }

                this.IsActive = this.Routes.Contains(NormalizeRoute(currentRoute));

                if (!this.IsActive)
                {
                    foreach (var route in this.Routes)
                    {
                        string normalizedRoute = NormalizeRoute(route);
                        if (normalizedRoute.EndsWith("{*}") && currentRoute.StartsWith(normalizedRoute.Substring(0, normalizedRoute.Length - 3)))
                        {
                            this.IsActive = true;
                            break;
                        }
                    }
                }
            }
        }

        private static string NormalizeRoute(string route)
        {
            if (!string.IsNullOrWhiteSpace(route))
            {
                route = route.ToLower().Trim();
                if (route.EndsWith("/"))
                {
                    route = route.Substring(0, route.Length - 1);
                }
            }

            return route;
        }
    }
}
