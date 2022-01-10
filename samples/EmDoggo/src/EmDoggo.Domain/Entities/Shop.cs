using System.Collections.Generic;
using Emeraude.Contracts;

namespace EmDoggo.Domain.Entities;

public class Shop : Entity
{
    public string Name { get; set; }

    public string Description { get; set; }
        
    public ICollection<ShopFood> Foods { get; set; }
}