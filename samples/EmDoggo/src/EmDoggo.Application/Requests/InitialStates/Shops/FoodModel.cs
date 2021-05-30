using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Common;
using EmDoggo.Domain.Entities;

namespace EmDoggo.Application.Requests.InitialStates.Shops
{
    public class FoodModel : IMapFrom<Food>
    {
        public string Name { get; set; }

        public FoodManufacturer Manufacturer { get; set; }
    }
}
