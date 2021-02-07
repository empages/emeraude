using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Seo.Attributes;
using Definux.Seo.Models;
using Definux.Emeraude.Tests.Project.Application.Requests.InitialStates.Home;

namespace Definux.Emeraude.Tests.Project.Pages
{
    [EmRoute]
    [EmLanguageRoute]
    [MetaTag(MainMetaTags.Title, "Home")]
    [MetaTag(MainMetaTags.Description, "Description")]
    public class HomePage : EmPage<HomeViewModel, HomeInitialStateQuery>
    {
    }
}