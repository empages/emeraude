using Definux.Emeraude.Client.EmPages.Models;
using System.Collections.Generic;
using Definux.Utilities.Objects;

namespace EmDoggo.Application.Requests.InitialStates.Dogs
{
    public class DogsViewModel : IEmViewModel
    {
        public IEnumerable<DogModel> Dogs { get; set; }
    }
}
