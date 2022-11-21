using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Results;

namespace EmDoggo.EmConfig.Pages.EditDog;

[EmRoute("/dogs/{dogId}/edit")]
public class EditDogPage : EmFormPage<EditDogPageModel>
{
    public EditDogPage(IEmPagesOptions options) : base(options)
    {
    }

    public override async Task SetupAsync()
    {
        throw new System.NotImplementedException();
    }

    public override async Task<EmFormPageResult> FetchDataAsync(EmPageRequest request)
    {
        throw new System.NotImplementedException();
    }
}