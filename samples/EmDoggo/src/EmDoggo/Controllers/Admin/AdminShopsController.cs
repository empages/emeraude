using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.UI.Utilities;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Emeraude.Admin.Utilities;
using EmDoggo.Application.Models.Admin.Shops;
using EmDoggo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmDoggo.Controllers.Admin
{
    [Route("/admin/shops/")]
    public class AdminShopsController : AdminEntityController<Shop, ShopViewModel>
    {
        protected override List<TableRowActionViewModel> BuildTableViewActions()
        {
            var actions = base.BuildTableViewActions();
            
            actions.Insert(1, new TableRowActionViewModel
            {
                Title = "Foods",
                Icon = MaterialDesignIcons.FoodApple,
                Method = TableRowActionMethod.Get,
                UrlStringFormat = $"{this.ControllerRoute}{{0}}/foods",
                RawParameters = new List<string> { "[Id]" },
            });

            return actions;
        }
    }
}
