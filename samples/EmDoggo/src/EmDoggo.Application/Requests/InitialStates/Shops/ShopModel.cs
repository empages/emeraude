using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Entities;
using System;
using System.Collections.Generic;

namespace EmDoggo.Application.Requests.InitialStates.Shops
{
    public class ShopModel : IMapFrom<Shop>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<ShopFoodModel> Foods { get; set; }
    }
}
