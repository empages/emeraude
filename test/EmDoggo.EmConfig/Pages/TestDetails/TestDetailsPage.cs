using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Pages.Details;

namespace EmDoggo.EmConfig.Pages.TestDetails;

[EmNavigationItem(11, "Test Details", "flag-variant")]
[EmRoute("/test/details")]
public class TestDetailsPage : EmDetailsPage<TestDetailsPageModel>
{
    public override async Task SetupAsync()
    {
    }

    public override async Task<EmDetailsPageResult> FetchDataAsync(EmPageRequest request)
    {
        return new EmDetailsPageResult
        {
            Model = new TestDetailsPageModel(),
        };
    }
}