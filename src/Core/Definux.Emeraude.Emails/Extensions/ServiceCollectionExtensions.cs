using Definux.Emeraude.Application.Emails;
using Definux.Emeraude.Emails.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Emails.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers email infrastructure.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterEmailSender(this IServiceCollection services)
        {
            services.AddScoped<IEmailSender, EmailSender>();

            return services;
        }
    }
}
