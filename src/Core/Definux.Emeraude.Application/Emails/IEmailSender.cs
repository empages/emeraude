using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Emails
{
    /// <summary>
    /// Service which gives methods for sending emails.
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Method that send email by Razor template name and <see cref="EmailModel"/>.
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<SendEmailResult> SendEmailAsync(string templateName, EmailModel model);
    }
}