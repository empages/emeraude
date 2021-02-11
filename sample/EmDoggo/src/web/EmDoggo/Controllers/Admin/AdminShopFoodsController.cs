using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using EmDoggo.Application.Models.Admin.Shops;
using EmDoggo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmDoggo.Controllers.Admin
{
    [Route("/admin/shops/{shopId}/foods/")]
    public class AdminShopFoodsController : AdminChildEntityController<ShopFood, ShopFoodViewModel, Shop, AdminShopsController>
    {
        public AdminShopFoodsController()
        {
            HasEdit = false;
        }

        protected override string ParentRouteKey => "shopId";

        protected override string ParentProperty => nameof(ShopFood.ShopId);

        protected override Expression<Func<ShopFood, bool>> ParentExpression => x => x.ShopId == ParentIdentifier;

        protected override List<string> GetOrderProperties()
        {
            return new List<string>
            {
                nameof(ShopFood.Id),
                nameof(ShopFood.Amount),
                nameof(ShopFood.CreatedOn),
                nameof(ShopFood.UpdatedOn)
            };
        }
    }
}
