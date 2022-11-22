using EmDoggo.Core.Data;
using EmPages.Pages;
using EmPages.Pages.Pages;

namespace EmDoggo.EmConfig.Pages.DogDetails;

public class DogDetailsPageModel : IEmPageModel
{
    public string Id { get; set; }
    
    public string Name { get; set; }

    public DogBreed Breed { get; set; }

    public int Age { get; set; }

    public bool Active { get; set; }
}