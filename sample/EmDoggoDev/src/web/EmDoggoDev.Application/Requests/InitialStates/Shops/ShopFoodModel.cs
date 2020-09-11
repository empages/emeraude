using Definux.Emeraude.Application.Common.Mapping;
using EmDoggoDev.Domain.Entities;
using System;

namespace EmDoggoDev.Application.Requests.InitialStates.Shops
{
    public class ShopFoodModel : IMapFrom<ShopFood>
    {
        public Guid Id { get; set; }

        public FoodModel Food { get; set; }

        public double Amount { get; set; }
    }
}
