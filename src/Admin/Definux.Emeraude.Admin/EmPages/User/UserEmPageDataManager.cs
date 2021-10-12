using Definux.Emeraude.Admin.EmPages.Data;
using Definux.Emeraude.Admin.EmPages.Services;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.User
{
    /// <summary>
    /// User EmPage data manager.
    /// </summary>
    public class UserEmPageDataManager : EmPageDataManager<UserEmPageModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEmPageDataManager"/> class.
        /// </summary>
        /// <param name="dataStrategy"></param>
        /// <param name="mediator"></param>
        /// <param name="emPageService"></param>
        public UserEmPageDataManager(
            UserEmPageDataStrategy dataStrategy,
            IMediator mediator,
            IEmPageService emPageService)
            : base(dataStrategy, mediator, emPageService)
        {
        }
    }
}