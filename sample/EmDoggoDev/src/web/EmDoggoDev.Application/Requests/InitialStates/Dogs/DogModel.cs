using Definux.Emeraude.Application.Common.Mapping;
using EmDoggoDev.Domain.Common;
using EmDoggoDev.Domain.Entities;
using System;

namespace EmDoggoDev.Application.Requests.InitialStates.Dogs
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
