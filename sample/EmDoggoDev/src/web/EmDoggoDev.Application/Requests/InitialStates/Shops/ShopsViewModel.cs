using Definux.Emeraude.Client.EmPages.Models;
using System.Collections.Generic;

namespace EmDoggoDev.Application.Requests.InitialStates.Shops
{
    public class ShopsViewModel : IEmViewModel
    {
        public IEnumerable<ShopModel> Shops { get; set; }
    }
}
