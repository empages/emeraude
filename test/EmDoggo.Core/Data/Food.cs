using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmDoggo.Core.Data;

public class Food : Entity
{
    public Food()
    {
        Shops = new HashSet<ShopFood>();
    }

    [Required]
    public string Name { get; set; }

    public FoodManufacturer Manufacturer { get; set; }

    public ICollection<ShopFood> Shops { get; set; }

    public string ImageUrl { get; set; }

    public DateTime PackageDate { get; set; }

    public DateTime? ExpirationDate { get; set; }
}