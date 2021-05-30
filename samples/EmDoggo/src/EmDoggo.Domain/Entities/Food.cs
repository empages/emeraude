using System;
using Definux.Emeraude.Domain.Entities;
using EmDoggo.Domain.Common;
using System.Collections.Generic;

namespace EmDoggo.Domain.Entities
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

        public DateTimeOffset RequiredDateTimeOffset { get; set; }

        public DateTimeOffset? OptionalDateTimeOffset { get; set; }
        
        public DateTime RequiredDateTime { get; set; }

        public DateTime? OptionalDateTime { get; set; }
    }
}
