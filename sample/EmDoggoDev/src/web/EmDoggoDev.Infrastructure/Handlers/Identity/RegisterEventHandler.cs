using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using EmDoggoDev.Application.Common.Interfaces;
using EmDoggoDev.Application.Common.Interfaces.Persistance;
using EmDoggoDev.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace EmDoggoDev.Infrastructure.Handlers.Identity
{
    public class RegisterEventHandler : IRegisterEventHandler
    {
        private readonly IEntityContext context;
        private readonly IEmailService emailService;

        public RegisterEventHandler(
            IEntityContext context,
            IEmailService emailService)
        {
            this.context = context;
            this.emailService = emailService;
        }

        public async Task HandleAsync(Guid userId, params string[] args)
        {
            this.context.Owners.Add(new Owner(userId));
            await this.context.SaveChangesAsync();
            
            await this.emailService.SendEmailConfirmationEmailAsync(userId);
        }
    }
}
