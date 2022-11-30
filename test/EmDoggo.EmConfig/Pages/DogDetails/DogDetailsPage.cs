using System;
using System.Threading.Tasks;
using EmDoggo.Core.Data;
using EmPages.Pages;
using EmPages.Pages.Pages;
using EmPages.Pages.Pages.Details;

namespace EmDoggo.EmConfig.Pages.DogDetails;

[EmRoute("/dogs/{dogId}")]
public class DogDetailsPage : EmDetailsPage<DogDetailsPageModel>
{
    private readonly EntityContext context;

    public DogDetailsPage(EntityContext context)
    {
        this.context = context;
    }

    public override async Task SetupAsync()
    {
    }

    public override async Task<EmDetailsPageResult> FetchDataAsync(EmPageRequest request)
    {
        var dogId = request.GetParameter<Guid>("dogId");
        var dog = await this.context.Dogs.FindAsync(dogId);
        if (dog is null)
        {
            throw new EmPageNotFoundException($"Cannot be found a dog for ID: {dogId}");
        }
        
        return new EmDetailsPageResult
        {
            Model = new DogDetailsPageModel
            {
                Id = dog.Id.ToString(),
                Name = dog.Name,
                Breed = dog.Breed,
            },
        };
    }
    
    public override string ComputeTitle(DogDetailsPageModel model)
    {
        return $"Dog '{model.Name}'";
    }
}