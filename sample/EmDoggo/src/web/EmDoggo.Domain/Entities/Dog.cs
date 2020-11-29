using Definux.Emeraude.Domain.Entities;
using EmDoggo.Domain.Common;
using System;
using System.Collections.Generic;

namespace EmDoggo.Domain.Entities
{
    public class Dog : Entity
    {
        public string Name { get; set; }

        public DogType Type { get; set; }

        public DogBreed Breed { get; set; }

        public Guid OwnerId { get; set; }

        public Owner Owner { get; set; }
    }
}
