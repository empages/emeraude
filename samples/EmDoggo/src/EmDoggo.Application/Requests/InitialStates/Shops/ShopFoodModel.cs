using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Entities;
using System;

namespace EmDoggo.Application.Requests.InitialStates.Shops
{
    public class ShopFoodModel : IMapFrom<ShopFood>
    {
        public Guid Id { get; set; }

        public FoodModel Food { get; set; }

        public double Amount { get; set; }
    }
}
