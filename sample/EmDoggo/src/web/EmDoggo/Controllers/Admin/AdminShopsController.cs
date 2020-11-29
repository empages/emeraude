using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Mapping.Mappers;
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

            actions.Insert(1, EntityTableMapper.CreateAction(
                "Foods",
                MaterialDesignIcons.FoodApple,
                TableRowActionMethod.Get,
                $"{this.ControllerRoute}{{0}}/foods",
                "[Id]"));

            return actions;
        }
    }
}
