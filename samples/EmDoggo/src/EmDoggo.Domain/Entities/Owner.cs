using System;
using System.Collections.Generic;
using Emeraude.Contracts;

namespace EmDoggo.Domain.Entities;

public class Owner : Entity
{
    public Owner()
    {
        Dogs = new HashSet<Dog>();
    }

    public Owner(Guid userId)
        : this()
    {
        UserId = userId;
    }

    public Guid UserId { get; set; }

    public string Address { get; set; }

    public ICollection<Dog> Dogs { get; set; }
}