using Definux.Emeraude.Application.Common.Results.Emails;
using EmDoggoDev.Application.Common.Interfaces;
using System;
using System.Threading.Tasks;

namespace EmDoggoDev.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public async Task<SendEmailResult> SendEmailConfirmationEmailAsync(Guid userId)
        {
            // send email

            return null;
        }
    }
}
