using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Tests.Project.Adapters
{
    public class AdminMenusBuilder : IAdminMenusBuilder
    {
        public async Task<AdminNavigationSchema> BuildAsync()
            => await Task.FromResult(new AdminNavigationSchema
            {
                InsightsItems = new List<SidebarInsightItem>
                {
                    new ()
                    {
                        Title = "Client Login",
                        Route = "/login",
                        Icon = "mdi mdi-account",
                        Blank = true
                    }
                },
                Menus = new List<SidebarMenuSectionItem>
                {
                    new ()
                    {
                        Title = "Dashboard",
                        Icon = "mdi mdi-television",
                        Children = new List<SidebarNavigationLinkItem>()
                        {
                            new ("Index", "/admin"),
                        }
                    }
                }
            });
    }
}