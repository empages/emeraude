using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Pages.Form;

namespace EmDoggo.EmConfig.Pages.CreateDog;

[EmRoute("/dogs/create")]
public class CreateDogPage : EmFormPage<CreateDogPageModel>
{
    public CreateDogPage(IEmPagesOptions options) : base(options)
    {
    }

    public override async Task SetupAsync()
    {
        this.ViewContext.ConfigureAll(this.Options);
        this.SetSubmitCommand<CreateDogPageSubmitCommand>();
    }

    public override async Task<EmFormPageResult> FetchDataAsync(EmPageRequest request)
    {
        throw new System.NotImplementedException();
    }
}