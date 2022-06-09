using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmDoggo.Core.Data;

public class ShopFood : Entity
{
    public Guid ShopId { get; set; }

    [ForeignKey(nameof(ShopId))]
    public Shop Shop { get; set; }

    public Guid FoodId { get; set; }

    [ForeignKey(nameof(FoodId))]
    public Food Food { get; set; }

    public double Amount { get; set; }
}