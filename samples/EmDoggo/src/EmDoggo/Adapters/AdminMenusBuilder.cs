using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.ViewModels.Layout.AdminMenus;
using Definux.Emeraude.Admin.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmDoggo.Adapters
{
    public class AdminMenusBuilder : IAdminMenusBuilder
    {
        public async Task<AdminNavigationSchema> BuildAsync(ViewContext context)
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
                        Children = new List<SidebarNavigationLinkItem>
                        {
                            new ("Index", "/admin"),
                        }
                    },
                    new ()
                    {   
                        Title = "Dogs",
                        Icon = $"mdi {MaterialDesignIcons.DogSide}",
                        Children = new List<SidebarNavigationLinkItem>
                        {
                            new ("Index", "/admin/dogs/", "/admin/dogs/{*}")
                        }
                    },
                    new ()
                    {   
                        Title = "Foods",
                        Icon = $"mdi {MaterialDesignIcons.FoodApple}",
                        Children = new List<SidebarNavigationLinkItem>
                        {
                            new ("Index", "/admin/foods/", "/admin/foods/{*}")
                        }
                    },
                    new ()
                    {   
                        Title = "Shops",
                        Icon = $"mdi {MaterialDesignIcons.Store}",
                        Children = new List<SidebarNavigationLinkItem>
                        {
                            new ("Index", "/admin/shops/", "/admin/shops/{*}")
                        }
                    },
                    new ()
                    {
                        Title = "Roots",
                        Icon = $"mdi {MaterialDesignIcons.FolderOpen}",
                        Children = new List<SidebarNavigationLinkItem>
                        {
                            new ("Public Root", "/admin/roots/public", "/admin/roots/public/{*}"),
                            new ("Private Root", "/admin/roots/private", "/admin/roots/private/{*}")
                        }
                    },
                    new ()
                    {   
                        Title = "Users",
                        Icon = $"mdi {MaterialDesignIcons.Account}",
                        Children = new List<SidebarNavigationLinkItem>
                        {
                            new ("Index", "/admin/users/", "/admin/users/{*}")
                        }
                    },
                }
            });
    }
}