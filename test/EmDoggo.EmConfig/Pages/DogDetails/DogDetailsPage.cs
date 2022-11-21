using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Results;

namespace EmDoggo.EmConfig.Pages.DogDetails;

[EmRoute("/dogs/{dogId}")]
public class DogDetailsPage : EmDetailsPage<DogDetailsPageModel>
{
    public DogDetailsPage(IEmPagesOptions options) : base(options)
    {
    }

    public override async Task SetupAsync()
    {
        throw new System.NotImplementedException();
    }

    public override async Task<EmDetailsPageResult> FetchDataAsync(EmPageRequest request)
    {
        throw new System.NotImplementedException();
    }
}