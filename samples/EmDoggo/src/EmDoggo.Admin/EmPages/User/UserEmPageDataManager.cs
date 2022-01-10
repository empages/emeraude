using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Services;
using MediatR;

namespace EmDoggo.Admin.EmPages.User;

public class UserEmPageDataManager : EmPageDataManager<UserEmPageModel>
{
    public UserEmPageDataManager(
        UserEmPageDataStrategy dataStrategy,
        IMediator mediator,
        IEmPageService emPageService)
        : base(dataStrategy, mediator, emPageService)
    {
    }
}