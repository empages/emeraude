using Definux.Emeraude.Application.Emails;
using EmDoggo.Application.Common.Interfaces;
using System;
using System.Threading.Tasks;

namespace EmDoggo.Infrastructure.Services
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
