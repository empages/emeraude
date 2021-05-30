using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    /// <summary>
    /// Model that defines the admin navigation schemes.
    /// </summary>
    public class AdminNavigationScheme
    {
        private const string DefaultSchemeFileName = "adminmenus.json";
        private readonly string schemeFileName = "adminmenus.{0}.json";

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminNavigationScheme"/> class.
        /// </summary>
        /// <param name="contentRootPath"></param>
        /// <param name="role"></param>
        public AdminNavigationScheme(string contentRootPath, string role)
        {
            string roleSchemePath = Path.Combine(contentRootPath, string.Format(this.schemeFileName, role));
            if (!File.Exists(roleSchemePath))
            {
                this.schemeFileName = DefaultSchemeFileName;
            }
            else
            {
                this.schemeFileName = roleSchemePath;
            }

            string schemeContentString = File.ReadAllText(Path.Combine(contentRootPath, this.schemeFileName));
            AdminNavigationScheme sheme = JsonConvert.DeserializeObject<AdminNavigationScheme>(schemeContentString);

            this.Menus = sheme.Menus;
            this.InsightsItems = sheme.InsightsItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminNavigationScheme"/> class.
        /// </summary>
        public AdminNavigationScheme()
        {
        }

        /// <summary>
        /// List of all sidebar items from the admin menu.
        /// </summary>
        [JsonProperty("navigation")]
        public List<SidebarMenuSectionItem> Menus { get; set; }

        /// <summary>
        /// List of all insight items from the admin menu.
        /// </summary>
        [JsonProperty("insights")]
        public List<SidebarInsightItem> InsightsItems { get; set; }

        /// <summary>
        /// Method that apply current route to the state of navigation items.
        /// </summary>
        /// <param name="currentRoute"></param>
        public void ApplyCurrentRoute(string currentRoute)
        {
            if (this.Menus != null && this.Menus.Count > 0)
            {
                foreach (var menu in this.Menus)
                {
                    menu.BuildState(currentRoute);
                }
            }
        }
    }
}
