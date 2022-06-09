using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Results;

namespace EmDoggo.EmConfig.Pages.CreateDog;

[EmRoute("/dogs/create")]
public class CreateDogPage : EmFormPage<CreateDogPageModel>
{
    public CreateDogPage(IEmPagesOptions options) : base(options)
    {
    }

    public override async Task SetupAsync()
    {
        throw new System.NotImplementedException();
    }

    public override async Task<EmFormPageResult<CreateDogPageModel>> FetchDataAsync(EmPageRequest request)
    {
        throw new System.NotImplementedException();
    }
}