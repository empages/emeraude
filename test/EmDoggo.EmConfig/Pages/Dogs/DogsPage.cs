using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Results;

namespace EmDoggo.EmConfig.Pages.Dogs;

[EmRoute("/dogs")]
public class DogsPage : EmTablePage<DogsPageModel>
{
    public DogsPage(IEmPagesOptions options) : base(options)
    {
    }

    public override async Task SetupAsync()
    {
        throw new System.NotImplementedException();
    }

    public override async Task<EmTablePageResult<DogsPageModel>> FetchDataAsync(EmPageRequest request)
    {
        throw new System.NotImplementedException();
    }
}