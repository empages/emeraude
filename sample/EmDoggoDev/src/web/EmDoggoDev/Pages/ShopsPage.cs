using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Emeraude.Configuration.Authorization;
using EmDoggoDev.Application.Requests.InitialStates.Shops;
using Microsoft.AspNetCore.Authorization;

namespace EmDoggoDev.Pages
{
    [EmRoute("/shops")]
    [EmLanguageRoute]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    public class ShopsPage : EmPage<ShopsViewModel, ShopsInitialStateQuery>
    {
    }
}
