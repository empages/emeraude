using Definux.Emeraude.Client.EmPages.Models;
using System.Collections.Generic;

namespace EmDoggoDev.Application.Requests.InitialStates.Dogs
{
    public class DogsViewModel : IEmViewModel
    {
        public IEnumerable<DogModel> Dogs { get; set; }
    }
}
