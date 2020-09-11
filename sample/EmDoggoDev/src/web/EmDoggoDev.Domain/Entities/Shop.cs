using Definux.Emeraude.Domain.Entities;
using System.Collections.Generic;

namespace EmDoggoDev.Domain.Entities
{
    public class Shop : Entity
    {
        public string Name { get; set; }

        public ICollection<ShopFood> Foods { get; set; }
    }
}
