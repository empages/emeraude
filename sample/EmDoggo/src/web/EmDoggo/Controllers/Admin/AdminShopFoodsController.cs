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

        public override string ParentRouteKey => "shopId";

        public override string ForeignKey => "ShopId";
    }
}
