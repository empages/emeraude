using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Client.EmPages.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
#pragma warning disable 612, 618
        /// <summary>
        /// Register EmPages required services.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterEmPages(this IServiceCollection services)
        {
            services.AddNodeServices();

            return services;
        }
#pragma warning restore 612, 618
    }
}