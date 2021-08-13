using System.Threading.Tasks;
using Definux.Emeraude.Application.Emails;

namespace Definux.Emeraude.Tests.Project.Infrastructure.Emails
{
    public class CustomEmailSender : IEmailSender
    {
        public async Task<SendEmailResult> SendEmailAsync(string templateName, EmailModel model)
        {
            return await Task.FromResult(SendEmailResult.SuccessResult);
        }
    }
}