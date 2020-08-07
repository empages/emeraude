using Definux.Emeraude.Application.Common.Interfaces.Emails;
using Definux.Emeraude.Emails.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Emails.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterEmailSender(this IServiceCollection services)
        {
            services.AddScoped<IEmailSender, EmailSender>();

            return services;
        }
    }
}
