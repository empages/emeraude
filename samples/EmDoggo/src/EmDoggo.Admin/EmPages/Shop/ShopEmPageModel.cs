using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Mapping;

namespace EmDoggo.Admin.EmPages.Shop;

public class ShopEmPageModel : IEmPageModel, IMapFrom<Domain.Entities.Shop>
{
    public string Id { get; set; }
    
    public string Name { get; set; }

    public string Description { get; set; }
}