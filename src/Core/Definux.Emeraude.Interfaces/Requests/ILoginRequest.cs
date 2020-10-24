namespace Definux.Emeraude.Interfaces.Requests
{
    /// <summary>
    /// Definition of login request of Emeraude client authentication.
    /// </summary>
    public interface ILoginRequest
    {
        /// <summary>
        /// Email of the user.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Password of the user.
        /// </summary>
        string Password { get; set; }
    }
}
