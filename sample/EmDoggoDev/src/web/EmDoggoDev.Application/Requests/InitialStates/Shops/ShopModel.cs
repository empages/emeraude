using Definux.Emeraude.Application.Common.Mapping;
using EmDoggoDev.Domain.Entities;
using System;
using System.Collections.Generic;

namespace EmDoggoDev.Application.Requests.InitialStates.Shops
{
    public class ShopModel : IMapFrom<Shop>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<ShopFoodModel> Foods { get; set; }
    }
}
