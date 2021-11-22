using System.Threading.Tasks;
using Emeraude.Application.Identity.Requests.Commands.Login;
using Emeraude.Application.Identity.Requests.Commands.LoginWithTwoFactorAuthentication;
using Emeraude.Presentation.PortalGateway.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Controllers.Admin
{
    /// <summary>
    /// Contract for admin authentication API controller that has to response on base route '/_em/api/admin/auth/'.
    /// </summary>
    public interface IAdminAuthApiController
    {
        /// <summary>
        /// Login POST action that has to response on 'login' route.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IActionResult> Login(AdminAuthLoginRequest request);

        /// <summary>
        /// Login with two factor authentication POST action that has to response on 'login-2fa' route.
        /// </summary>
        /// <param name="postAuthenticationToken"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IActionResult> LoginWithTwoFactorAuthentication(
            string postAuthenticationToken,
            AdminAuthLoginWithTwoFactorRequest request);

        /// <summary>
        /// Check POST action that has to response on 'check' route.
        /// </summary>
        /// <returns></returns>
        Task<IActionResult> CheckAuthorization();
    }
}