using Definux.Emeraude.Application.Mapping;
using EmDoggoDev.Domain.Common;
using EmDoggoDev.Domain.Entities;

namespace EmDoggoDev.Application.Requests.InitialStates.Shops
{
    public class FoodModel : IMapFrom<Food>
    {
        public string Name { get; set; }

        public FoodManufacturer Manufacturer { get; set; }
    }
}
