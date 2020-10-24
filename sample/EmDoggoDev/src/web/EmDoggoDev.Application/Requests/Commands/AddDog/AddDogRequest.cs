using Definux.Emeraude.Application.Mapping;
using EmDoggoDev.Domain.Common;
using EmDoggoDev.Domain.Entities;

namespace EmDoggoDev.Application.Requests.Commands.AddDog
{
    public class AddDogRequest : IMapFrom<Dog>
    {
        public string Name { get; set; }

        public DogType Type { get; set; }

        public DogBreed Breed { get; set; }
    }
}
