using System.Threading.Tasks;
using EmPages.Pages;
using EmPages.Pages.Components.Mutators;
using EmPages.Pages.Pages.Form;

namespace EmDoggo.EmConfig.Pages.TestForm;

[EmNavigationItem(12, "Test Form", "flag-variant")]
[EmRoute("/test/form")]
public class TestFormPage : EmFormPage<TestFormPageModel>
{
    public TestFormPage(IEmPagesOptions options)
        : base(options)
    {
    }

    public override async Task SetupAsync()
    {
        this.SetSubmitCommand<TestFormPageSubmitCommand>();
        this.ViewContext.ConfigureAll(this.Options);
        this.ViewContext.Configure(x => x.EnumSelect, viewItem =>
        {
            viewItem.SetComponent<EmMultiChoiceMutator>(c =>
            {
                c.MultiChoiceType = MultiChoiceType.Select;
            });
        });

        this.ViewContext.Configure(x => x.NullableEnumSelect, viewItem =>
        {
            viewItem.SetComponent<EmMultiChoiceMutator>(c =>
            {
                c.MultiChoiceType = MultiChoiceType.Select;
            });
        });
        
        this.ViewContext.Configure(x => x.EnumRadio, viewItem =>
        {
            viewItem.SetComponent<EmMultiChoiceMutator>(c =>
            {
                c.MultiChoiceType = MultiChoiceType.RadioGroup;
            });
        });
        
        this.ViewContext.Configure(x => x.NullableEnumRadio, viewItem =>
        {
            viewItem.SetComponent<EmMultiChoiceMutator>(c =>
            {
                c.MultiChoiceType = MultiChoiceType.RadioGroup;
            });
        });

        this.ViewContext.Configure(x => x.EnumEnumerable, viewItem =>
        {
            viewItem.SetComponent<EmMultiChoiceMutator>(c =>
            {
                c.MultiChoiceType = MultiChoiceType.CheckboxGroup;
            });
        });
    }

    public override async Task<EmFormPageResult> FetchDataAsync(EmPageRequest request)
    {
        return new EmFormPageResult
        {
            Model = new TestFormPageModel(),
        };
    }
}