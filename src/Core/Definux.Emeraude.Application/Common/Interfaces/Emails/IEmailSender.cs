using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Models.Emails;
using Definux.Emeraude.Application.Common.Results.Emails;

namespace Definux.Emeraude.Application.Common.Interfaces.Emails
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