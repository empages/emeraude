using Definux.Emeraude.Application.Common.Results.Emails;
using System;
using System.Threading.Tasks;

namespace EmDoggoDev.Application.Common.Interfaces
{
    public interface IEmailService
    {
        Task<SendEmailResult> SendEmailConfirmationEmailAsync(Guid userId);
    }
}
