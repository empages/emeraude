using Definux.Emeraude.Application.EventHandlers;
using EmDoggo.Application.Interfaces;
using EmDoggo.Domain.Entities;
using System.Threading.Tasks;

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
        
        public async Task HandleAsync(RegisterEventArgs args)
        {
            this.context.Owners.Add(new Owner(args.UserId));
            await this.context.SaveChangesAsync();
            
            await this.emailService.SendEmailConfirmationEmailAsync(args.UserId);
        }
    }
}
