using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Emeraude.Client.EmPages.Models;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Seo.Attributes;
using Definux.Seo.Models;
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
    [MetaTag(MainMetaTags.Title, "PageTitle", true)]
    [MetaTag(MainMetaTags.Description, "PageDescription", true)]
    [MetaTag(MainMetaTags.Image, "https://definux.io/assets/images/meta_image.jpg")]
    [Canonical("/dogs")]
    public class DogsPage : EmPage<DogsViewModel, DogsInitialStateQuery>
    {
        protected async override Task<Dictionary<string, object>> InitializeViewDataAsync(InitialStateModel<DogsViewModel> model)
        {
            return new Dictionary<string, object>
            {
                { "SomeToken", Guid.NewGuid() }
            };
        }

        protected override Task<MetaTagsModel> InitializeMetaTagsAsync(InitialStateModel<DogsViewModel> model)
        {
            AddTranslatedValueIntoViewData("PageTitle", "DOGS");
            AddTranslatedValueIntoViewData("PageDescription", "DOGS");

            return base.InitializeMetaTagsAsync(model);
        }
    }
}
