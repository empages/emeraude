using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.EventHandlers;
using Microsoft.AspNetCore.Http;

namespace EmDoggo.Infrastructure.Handlers.Identity
{
    public class RequestChangeEmailEventHandler : IRequestChangeEmailEventHandler
    {
        public async Task HandleAsync(RequestChangeEmailEventArgs args)
        {
            Console.WriteLine($"-->> {args.EmailConfirmationLink}");
        }
    }
}