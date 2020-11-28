using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Seo.Attributes;
using Definux.Seo.Models;
using EmDoggo.Application.Requests.InitialStates.Home;

namespace EmDoggo.Pages
{
    [EmRoute]
    [EmLanguageRoute]
    [MetaTag(MainMetaTags.Title, "Home")]
    [MetaTag(MainMetaTags.Description, "PageDescription")]
    [MetaTag(MainMetaTags.Image, "https://definux.io/assets/images/meta_image.jpg")]
    [Canonical("/")]
    public class HomePage : EmPage<HomeViewModel, HomeInitialStateQuery>
    {
    }
}
