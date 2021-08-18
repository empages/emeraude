namespace Definux.Emeraude.Emails.Options
{
    /// <summary>
    /// Implementation of SMTP options.
    /// </summary>
    public class SmtpOptions
    {
        /// <summary>
        /// Host of the email server.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port of the email server.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Flag that indicates a usage of SSL connection.
        /// </summary>
        public bool UseSsl { get; set; }

        /// <summary>
        /// Name of the email sender.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email address of the email sender.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Username for email server authentication.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password for email server authentication.
        /// </summary>
        public string Password { get; set; }
    }
}