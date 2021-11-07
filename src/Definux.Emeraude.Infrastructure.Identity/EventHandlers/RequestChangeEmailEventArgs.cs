namespace Definux.Emeraude.Infrastructure.Identity.EventHandlers
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

        /// <summary>
        /// Requested new email.
        /// </summary>
        public string NewEmail { get; set; }
    }
}