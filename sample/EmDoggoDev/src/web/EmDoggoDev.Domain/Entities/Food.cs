using Definux.Emeraude.Domain.Entities;
using EmDoggoDev.Domain.Common;
using System.Collections.Generic;

namespace EmDoggoDev.Domain.Entities
{
    public class Food : Entity, IEntityWithImage
    {
        public Food()
        {
            Shops = new HashSet<ShopFood>();
        }

        public string Name { get; set; }

        public FoodManufacturer Manufacturer { get; set; }

        public ICollection<ShopFood> Shops { get; set; }

        public string ImageUrl { get; set; }
    }
}
