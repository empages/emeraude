using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Services;
using MediatR;

namespace EmDoggo.Admin.EmPages.Shop;

public class ShopEmPageDataManager : EmPageDataManager<ShopEmPageModel>
{
    public ShopEmPageDataManager(
        ShopEmPageDataStrategy dataStrategy,
        IMediator mediator,
        IEmPageService emPageService)
        : base(dataStrategy, mediator, emPageService)
    {
    }
}