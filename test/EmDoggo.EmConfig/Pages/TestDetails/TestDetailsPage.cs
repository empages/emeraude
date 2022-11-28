using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Pages.Details;

namespace EmDoggo.EmConfig.Pages.TestDetails;

[EmNavigationItem(11, "Test Details", "flag-variant")]
[EmRoute("/test/details")]
public class TestDetailsPage : EmDetailsPage<TestDetailsPageModel>
{
    public TestDetailsPage(IEmPagesOptions options)
        : base(options)
    {
    }

    public override async Task SetupAsync()
    {
        this.ViewContext.ConfigureAll(this.Options);
    }

    public override async Task<EmDetailsPageResult> FetchDataAsync(EmPageRequest request)
    {
        return new EmDetailsPageResult
        {
            Model = new TestDetailsPageModel(),
        };
    }
}