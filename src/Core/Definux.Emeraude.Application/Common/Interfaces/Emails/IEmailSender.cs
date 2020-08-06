using Definux.Emeraude.Application.Common.Models.Emails;
using Definux.Emeraude.Application.Common.Results.Emails;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Emails
{
    public interface IEmailSender
    {
        Task<SendEmailResult> SendEmailAsync(string templateName, EmailModel model);
    }
}
