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
using Definux.Emeraude.Client.EmPages;

namespace EmDoggo.Pages
{
    [EmRoute("/dogs")]
    [EmLanguageRoute]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    [MetaTag(MainMetaTags.Title, EmPagesConstants.PageMetaTagTitleKey, true)]
    [MetaTag(MainMetaTags.Description, EmPagesConstants.PageMetaTagDescriptionKey, true)]
    public class DogsPage : EmPage<DogsViewModel, DogsInitialStateQuery>
    {
        protected async override Task<Dictionary<string, object>> InitializeViewDataAsync(InitialStateModel<DogsViewModel> model)
        {
            return new Dictionary<string, object>
            {
                { "SomeToken", Guid.NewGuid() }
            };
        }

        protected override Task<MetaTagsModel> InitializeMetaTagsAsync(InitialStateModel<DogsViewModel> model, bool disableDefaultDecoratedTags = false)
        {
            AddTranslatedValueIntoViewData(EmPagesConstants.PageMetaTagTitleKey, "DOGS");
            AddTranslatedValueIntoViewData(EmPagesConstants.PageMetaTagDescriptionKey, "DOGS");
        
            return base.InitializeMetaTagsAsync(model, disableDefaultDecoratedTags);
        }
    }
}
