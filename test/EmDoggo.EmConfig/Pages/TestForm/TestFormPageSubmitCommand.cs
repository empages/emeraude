using System;
using System.Threading.Tasks;
using EmPages.Pages;

namespace EmDoggo.EmConfig.Pages.TestForm;

public class TestFormPageSubmitCommand : IEmPageCommand
{
    public async Task<EmPageCommandResult> HandleAsync(EmPageRequest request)
    {
        Console.WriteLine("Submit");
        return new EmPageCommandResult();
    }
}