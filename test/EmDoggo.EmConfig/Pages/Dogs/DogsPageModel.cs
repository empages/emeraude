using EmDoggo.Core.Data;
using EmPages.Pages;

namespace EmDoggo.EmConfig.Pages.Dogs;

public class DogsPageModel : IEmPageModel
{
    public string Id { get; set; }
    
    public string Name { get; set; }

    public DogBreed Breed { get; set; }

    public int Age { get; set; }

    public bool Active { get; set; }
}