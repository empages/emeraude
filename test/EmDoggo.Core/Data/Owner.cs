using System;
using System.Collections.Generic;

namespace EmDoggo.Core.Data;

public class Owner : Entity
{
    public Owner()
    {
        Dogs = new HashSet<Dog>();
    }

    public string Name { get; set; }

    public string Address { get; set; }

    public ICollection<Dog> Dogs { get; set; }
}