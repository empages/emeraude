using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Definux.Emeraude.Admin.UI.AdminMenu
{
    public class AdminNavigationScheme
    {
        private readonly string schemeFileName = "adminmenus.{0}.json";
        private const string DefaultSchemeFileName = "adminmenus.json";

        public AdminNavigationScheme(string contentRootPath, string role)
        {
            string roleSchemePath = Path.Combine(contentRootPath, string.Format(schemeFileName, role));
            if (!File.Exists(roleSchemePath))
            {
                this.schemeFileName = DefaultSchemeFileName;
            }
            else
            {
                this.schemeFileName = roleSchemePath;
            }

            string schemeContentString = File.ReadAllText(Path.Combine(contentRootPath, schemeFileName));
            AdminNavigationScheme sheme = JsonConvert.DeserializeObject<AdminNavigationScheme>(schemeContentString);
            this.Menus = sheme.Menus;
        }

        public AdminNavigationScheme()
        {

        }

        [JsonProperty("navigation")]
        public List<SidebarMenuSectionItem> Menus { get; set; }
    }
}
