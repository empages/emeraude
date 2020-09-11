using Definux.Emeraude.Identity.Extensions;
using EmDoggoDev.Application.Common.Interfaces;
using EmDoggoDev.Infrastructure.Handlers.Identity;
using EmDoggoDev.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EmDoggoDev.Infrastructure.Extensions
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
