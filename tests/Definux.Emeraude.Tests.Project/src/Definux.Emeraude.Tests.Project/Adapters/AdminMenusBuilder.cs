using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.Models;
using Definux.Emeraude.Admin.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;

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
                        Icon = $"mdi {MaterialDesignIcons.Account}",
                        Blank = true
                    }
                },
                Menus = new List<SidebarMenuSectionItem>
                {
                    new ()
                    {
                        Title = "Dashboard",
                        Icon = $"mdi {MaterialDesignIcons.Television}",
                        Children = new List<SidebarNavigationLinkItem>()
                        {
                            new ("Index", "/admin"),
                        }
                    },
                    new ()
                    {
                        Title = "Roots",
                        Icon = $"mdi {MaterialDesignIcons.FolderOpen}",
                        Children = new List<SidebarNavigationLinkItem>()
                        {
                            new ("Public Root", "/admin/roots/public", "/admin/roots/public/{*}"),
                            new ("Private Root", "/admin/roots/private", "/admin/roots/private/{*}")
                        }
                    }
                }
            });
    }
}