using Definux.Emeraude.Admin.Controllers.Abstractions;
using EmDoggoDev.Application.Models.Admin.Shops;
using EmDoggoDev.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmDoggoDev.Controllers.Admin
{
    [Route("/admin/shops/{shopId}/foods/")]
    public class AdminShopFoodsController : AdminChildEntityController<ShopFood, ShopFoodViewModel, Shop, AdminShopsController>
    {
        public AdminShopFoodsController()
        {
            HasEdit = false;
        }

        public override string ParentRouteKey => "shopId";

        public override string ForeignKey => "ShopId";
    }
}
