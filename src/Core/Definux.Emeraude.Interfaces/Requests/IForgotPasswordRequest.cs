namespace Definux.Emeraude.Interfaces.Requests
{
    /// <summary>
    /// Definition of forgot password request of Emeraude client authentication.
    /// </summary>
    public interface IForgotPasswordRequest
    {
        /// <summary>
        /// Email of the user.
        /// </summary>
        string Email { get; set; }
    }
}
