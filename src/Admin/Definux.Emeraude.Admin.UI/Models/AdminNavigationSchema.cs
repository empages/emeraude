using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Model that defines the admin navigation schemes.
    /// </summary>
    public class AdminNavigationSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminNavigationSchema"/> class.
        /// </summary>
        public AdminNavigationSchema()
        {
            this.Menus = new List<SidebarMenuSectionItem>();
            this.InsightsItems = new List<SidebarInsightItem>();
        }

        /// <summary>
        /// List of all sidebar items from the admin menu.
        /// </summary>
        public List<SidebarMenuSectionItem> Menus { get; set; }

        /// <summary>
        /// List of all insight items from the admin menu.
        /// </summary>
        public List<SidebarInsightItem> InsightsItems { get; set; }

        /// <summary>
        /// Method that apply current route to the state of navigation items. This method is called automatically by the framework.
        /// </summary>
        /// <param name="currentRoute"></param>
        public void ChangeNavigationState(string currentRoute)
        {
            string route = currentRoute.StartsWith("/") ? currentRoute : $"/{currentRoute}";
            Console.WriteLine($@"Changing navigation state with route: '{route}'");

            if (this.Menus != null && this.Menus.Count > 0)
            {
                foreach (var menu in this.Menus)
                {
                    menu.BuildState(route);
                }
            }
        }
    }
}
