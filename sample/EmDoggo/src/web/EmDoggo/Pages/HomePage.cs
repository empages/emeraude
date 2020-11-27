using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using EmDoggo.Application.Requests.InitialStates.Home;

namespace EmDoggo.Pages
{
    [EmRoute]
    [EmLanguageRoute]
    public class HomePage : EmPage<HomeViewModel, HomeInitialStateQuery>
    {
    }
}
