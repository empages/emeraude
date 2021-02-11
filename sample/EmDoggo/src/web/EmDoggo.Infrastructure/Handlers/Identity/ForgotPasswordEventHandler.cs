using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Emails;
using Definux.Emeraude.Application.EventHandlers;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Localization;
using EmDoggo.Application.Emails;

namespace EmDoggo.Infrastructure.Handlers.Identity
{
    public class ForgotPasswordEventHandler : IForgotPasswordEventHandler
    {
        private readonly IEmailSender emailSender;
        private readonly ICurrentLanguageProvider currentLanguageProvider;
        private readonly IUserManager userManager;

        public ForgotPasswordEventHandler(IEmailSender emailSender, ICurrentLanguageProvider currentLanguageProvider, IUserManager  userManager)
        {
            this.emailSender = emailSender;
            this.currentLanguageProvider = currentLanguageProvider;
            this.userManager = userManager;
        }
        
        public async Task HandleAsync(ForgotPasswordEventArgs args)
        {
            var targetUser = await this.userManager.FindUserByIdAsync(args.UserId);
            var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
            await this.emailSender.SendEmailAsync($"ResetPassword.{currentLanguage.Code}", new ResetPasswordEmailModel
            {
                Name = targetUser.Name,
                Email = targetUser.Email,
                Subject = "Reset Password",
                ResetPasswordLink = args.ResetPasswordLink,
            });
            
            Console.WriteLine($"-->> {args.ResetPasswordLink}");
        }
    }
}