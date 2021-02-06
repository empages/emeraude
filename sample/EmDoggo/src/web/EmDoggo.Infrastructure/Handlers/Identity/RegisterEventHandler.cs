using Definux.Emeraude.Application.EventHandlers;
using EmDoggo.Application.Interfaces;
using EmDoggo.Domain.Entities;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EmDoggo.Infrastructure.Handlers.Identity
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

        public async Task HandleAsync(Guid userId, HttpContext httpContext, params string[] args)
        {
            this.context.Owners.Add(new Owner(userId));
            await this.context.SaveChangesAsync();
            
            await this.emailService.SendEmailConfirmationEmailAsync(userId);
        }
    }
}
