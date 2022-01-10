using System;
using Emeraude.Contracts;

namespace EmDoggo.Domain.Entities;

public class ShopFood : AuditableEntity
{
    public Guid ShopId { get; set; }

    public Shop Shop { get; set; }

    public Guid FoodId { get; set; }

    public Food Food { get; set; }

    public double Amount { get; set; }
}