namespace Definux.Emeraude.Application.EventHandlers
{
    /// <summary>
    /// Event arguments for register event handler.
    /// </summary>
    public class RegisterEventArgs : IdentityEventArgs
    {
        /// <summary>
        /// Email confirmation link.
        /// </summary>
        public string EmailConfirmationLink { get; set; }
    }
}