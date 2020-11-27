using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Emeraude.Client.EmPages.Models;
using Definux.Emeraude.Configuration.Authorization;
using EmDoggo.Application.Requests.InitialStates.Dogs;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmDoggo.Pages
{
    [EmRoute("/dogs")]
    [EmLanguageRoute]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    public class DogsPage : EmPage<DogsViewModel, DogsInitialStateQuery>
    {
        protected async override Task<Dictionary<string, object>> InitializeViewDataAsync(InitialStateModel<DogsViewModel> model)
        {
            return new Dictionary<string, object>
            {
                { "SomeToken", Guid.NewGuid() }
            };
        }
    }
}
