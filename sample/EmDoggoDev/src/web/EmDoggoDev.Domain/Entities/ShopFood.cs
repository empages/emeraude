using Definux.Emeraude.Domain.Entities;
using System;

namespace EmDoggoDev.Domain.Entities
{
    public class ShopFood : AuditableEntity
    {
        public Guid ShopId { get; set; }

        public Shop Shop { get; set; }

        public Guid FoodId { get; set; }

        public Food Food { get; set; }

        public double Amount { get; set; }
    }
}
