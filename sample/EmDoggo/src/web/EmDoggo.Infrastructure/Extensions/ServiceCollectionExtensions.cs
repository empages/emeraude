using Definux.Emeraude.Identity.Extensions;
using EmDoggo.Application.Interfaces;
using EmDoggo.Infrastructure.Handlers.Identity;
using EmDoggo.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EmDoggo.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IHelperService, HelperService>();

            services.SubscribeToRegisterEvent<RegisterEventHandler>();

            return services;
        }
    }
}
