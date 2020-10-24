using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword
{
    /// <inheritdoc cref="IForgotPasswordRequest"/>
    public class ForgotPasswordRequest : IForgotPasswordRequest
    {
        /// <inheritdoc/>
        public string Email { get; set; }
    }
}
