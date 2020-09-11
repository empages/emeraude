using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using EmDoggoDev.Application.Requests.InitialStates.Home;

namespace EmDoggoDev.Pages
{
    [EmRoute]
    [EmLanguageRoute]
    public class HomePage : EmPage<HomeViewModel, HomeInitialStateQuery>
    {
    }
}
