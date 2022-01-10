using System;
using EmDoggo.Domain.Common;
using System.Collections.Generic;
using Emeraude.Contracts;

namespace EmDoggo.Domain.Entities;

public class Food : Entity
{
    public Food()
    {
        Shops = new HashSet<ShopFood>();
    }

    public string Name { get; set; }

    public FoodManufacturer Manufacturer { get; set; }

    public ICollection<ShopFood> Shops { get; set; }

    public string ImageUrl { get; set; }

    public DateTime PackageDate { get; set; }

    public DateTime? ExpirationDate { get; set; }
}