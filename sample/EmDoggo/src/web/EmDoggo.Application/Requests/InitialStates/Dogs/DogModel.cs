using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Common;
using EmDoggo.Domain.Entities;
using System;

namespace EmDoggo.Application.Requests.InitialStates.Dogs
{
    public class DogModel : IMapFrom<Dog>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DogType Type { get; set; }

        public DogBreed Breed { get; set; }

        public string ImageUrl { get; set; }
    }
}
