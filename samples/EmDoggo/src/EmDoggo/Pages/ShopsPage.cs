using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Seo.Attributes;
using Definux.Seo.Models;
using EmDoggo.Application.Requests.InitialStates.Shops;
using Microsoft.AspNetCore.Authorization;

namespace EmDoggo.Pages
{
    [EmRoute("/shops")]
    [EmLanguageRoute]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    public class ShopsPage : EmPage<ShopsViewModel, ShopsInitialStateQuery>
    {
    }
}
