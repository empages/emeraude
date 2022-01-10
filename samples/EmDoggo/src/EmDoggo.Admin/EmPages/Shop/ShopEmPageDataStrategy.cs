using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Data.Requests;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Utilities;

namespace EmDoggo.Admin.EmPages.Shop;

public class ShopEmPageDataStrategy : EmPageEntityDataStrategy<Domain.Entities.Shop, ShopEmPageModel>
{
    public ShopEmPageDataStrategy()
    {
        this.AvailableOrderExpressions.Add("Name", x => x.Name);
    }
}