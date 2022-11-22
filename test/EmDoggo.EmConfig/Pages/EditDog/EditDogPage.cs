using System;
using System.Threading.Tasks;
using EmDoggo.Core.Data;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Pages.Form;
using Microsoft.EntityFrameworkCore;

namespace EmDoggo.EmConfig.Pages.EditDog;

[EmRoute("/dogs/{dogId}/edit")]
public class EditDogPage : EmFormPage<EditDogPageModel>
{
    private readonly EntityContext context;

    public EditDogPage(EntityContext context, IEmPagesOptions options)
        : base(options)
    {
        this.context = context;
    }

    public override async Task SetupAsync()
    {
        this.ViewContext.ConfigureAll(this.Options);
        this.SetSubmitCommand<EditDogPageSubmitCommand>();
    }

    public override async Task<EmFormPageResult> FetchDataAsync(EmPageRequest request)
    {
        var dogId = request.GetParameter<Guid>("dogId");
        var dog = await this.context.Dogs.FindAsync(dogId);
        if (dog is null)
        {
            throw new EmPageNotFoundException($"Cannot be found a dog for ID: {dogId}");
        }
        
        return new EmFormPageResult
        {
            Model = new EditDogPageModel
            {
                Id = dog.Id.ToString(),
                Name = dog.Name,
                Breed = dog.Breed,
            },
        };
    }

    public override string ComputeTitle(EditDogPageModel model)
    {
        return $"Edit Dog '{model.Name}'";
    }
}