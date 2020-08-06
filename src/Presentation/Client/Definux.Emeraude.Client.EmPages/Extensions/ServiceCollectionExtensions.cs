using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Client.EmPages.Extensions
{
    public static class ServiceCollectionExtensions
    {
#pragma warning disable 612, 618
        public static IServiceCollection RegisterEmPages(this IServiceCollection services)
        {
            services.AddNodeServices();

            return services;
        }
#pragma warning restore 612, 618
    }
}