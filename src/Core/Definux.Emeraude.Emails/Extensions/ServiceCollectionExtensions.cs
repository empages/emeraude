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
        /// <param name="options"></param>
        public static void RegisterEmailInfrastructure(this IServiceCollection services, EmEmailOptions options)
        {
            services.AddScoped<IEmailRenderer, EmailRenderer>();
            if (options == null || options.EmailSenderImplementationType == null)
            {
                services.AddScoped<IEmailSender, EmailSender>();
            }
            else
            {
                services.AddScoped(typeof(IEmailSender), options.EmailSenderImplementationType);
            }
        }
    }
}
