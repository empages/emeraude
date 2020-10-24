namespace Definux.Emeraude.Application.Emails
{
    /// <summary>
    /// Implementation of model that contains core information about the email instance.
    /// </summary>
    public class EmailModel
    {
        /// <summary>
        /// Receiver email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Receiver name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email subject.
        /// </summary>
        public string Subject { get; set; }
    }
}
