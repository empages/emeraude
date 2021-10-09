namespace Definux.Emeraude.Admin.UI.Models.Logging
{
    /// <summary>
    /// Model that encapsulate email log.
    /// </summary>
    public class EmailLogModel : LogEntityModel
    {
        /// <summary>
        /// Receiver of the email.
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Body of the email.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Flag that indicates whether email is sent or not.
        /// </summary>
        public bool Sent { get; set; }
    }
}