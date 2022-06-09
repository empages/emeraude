using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmDoggo.Core.Data;

public class Shop : Entity
{
    [Required]
    public string Name { get; set; }

    public string Description { get; set; }
        
    public ICollection<ShopFood> Foods { get; set; }
}