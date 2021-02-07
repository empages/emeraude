using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Tests.Project.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
