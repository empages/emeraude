using Definux.Emeraude.Application.Emails;
using System;
using System.Threading.Tasks;

namespace EmDoggo.Application.Common.Interfaces
{
    public interface IEmailService
    {
        Task<SendEmailResult> SendEmailConfirmationEmailAsync(Guid userId);
    }
}
