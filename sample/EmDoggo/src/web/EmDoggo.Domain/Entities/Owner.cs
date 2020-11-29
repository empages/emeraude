using Definux.Emeraude.Domain.Entities;
using System;
using System.Collections.Generic;

namespace EmDoggo.Domain.Entities
{
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
}
