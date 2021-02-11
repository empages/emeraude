namespace Definux.Emeraude.Application.EventHandlers
{
    /// <summary>
    /// Event arguments for request change email event handler.
    /// </summary>
    public class RequestChangeEmailEventArgs : IdentityEventArgs
    {
        /// <summary>
        /// Email confirmation link.
        /// </summary>
        public string EmailConfirmationLink { get; set; }
    }
}