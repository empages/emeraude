using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.EventHandlers;
using Microsoft.AspNetCore.Http;

namespace EmDoggo.Infrastructure.Handlers.Identity
{
    public class ForgotPasswordEventHandler: IForgotPasswordEventHandler
    {
        public async Task HandleAsync(Guid userId, HttpContext httpContext, params string[] args)
        {
            Console.WriteLine($"-->> {args[0]}");
        }
    }
}