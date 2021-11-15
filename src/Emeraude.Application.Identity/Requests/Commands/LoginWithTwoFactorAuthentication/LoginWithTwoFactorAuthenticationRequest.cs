namespace Emeraude.Application.Identity.Requests.Commands.LoginWithTwoFactorAuthentication
{
    /// <summary>
    /// Request for user login with two factor authentication.
    /// </summary>
    public class LoginWithTwoFactorAuthenticationRequest
    {
        /// <summary>
        /// Email of the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Two factor authentication code.
        /// </summary>
        public string Code { get; set; }
    }
}