using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Infrastructure.Identity.EventHandlers
{
    /// <summary>
    /// Event manager that trigger all identity related events on successful execution of authentication operation.
    /// </summary>
    public interface IIdentityEventManager
    {
        /// <summary>
        /// Trigger <see cref="ILoginEventHandler"/>.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task TriggerLoginEventAsync(Guid userId);

        /// <summary>
        /// Trigger <see cref="IExternalLoginEventHandler"/>.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task TriggerExternalLoginEventAsync(Guid userId);

        /// <summary>
        /// Trigger <see cref="IRegisterEventHandler"/>.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="confirmationLink"></param>
        /// <returns></returns>
        Task TriggerRegisterEventAsync(Guid userId, string confirmationLink);

        /// <summary>
        /// Trigger <see cref="IExternalRegisterEventHandler"/>.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task TriggerExternalRegisterEventAsync(Guid userId);

        /// <summary>
        /// Trigger <see cref="IForgotPasswordEventHandler"/>.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="resetPasswordLink"></param>
        /// <returns></returns>
        Task TriggerForgotPasswordEventAsync(Guid userId, string resetPasswordLink);

        /// <summary>
        /// Trigger <see cref="IResetPasswordEventHandler"/>.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task TriggerResetPasswordEventAsync(Guid userId);

        /// <summary>
        /// Trigger <see cref="IConfirmedEmailEventHandler"/>.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task TriggerConfirmedEmailEventAsync(Guid userId);

        /// <summary>
        /// Trigger <see cref="IRequestChangeEmailEventHandler"/>.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="newEmail"></param>
        /// <param name="changeEmailConfirmationLink"></param>
        /// <returns></returns>
        Task TriggerRequestChangeEmailEventAsync(Guid userId, string newEmail, string changeEmailConfirmationLink);
    }
}
