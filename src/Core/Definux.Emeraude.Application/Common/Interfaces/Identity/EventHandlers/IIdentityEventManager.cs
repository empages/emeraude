using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers
{
    public interface IIdentityEventManager
    {
        Task TriggerLoginEventAsync(Guid userId);

        Task TriggerExternalLoginEventAsync(Guid userId);

        Task TriggerRegisterEventAsync(Guid userId);

        Task TriggerExternalRegisterEventAsync(Guid userId);

        Task TriggerForgotPasswordEventAsync(Guid userId, string resetPasswordLink);

        Task TriggerResetPasswordEventAsync(Guid userId);

        Task TriggerConfirmedEmailEventAsync(Guid userId);
    }
}
