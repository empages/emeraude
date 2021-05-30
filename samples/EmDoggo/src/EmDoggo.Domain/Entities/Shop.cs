using Definux.Emeraude.Domain.Entities;
using System.Collections.Generic;

namespace EmDoggo.Domain.Entities
{
    public class Shop : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
        public ICollection<ShopFood> Foods { get; set; }
    }
}
