using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Essentials.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register all types that implements specified contract in the selected assemblies.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="contracts"></param>
        /// <param name="assemblies"></param>
        public static void RegisterAsScopedAllContractedTypes(
            this IServiceCollection services,
            IEnumerable<Type> contracts,
            IEnumerable<Assembly> assemblies)
        {
            var typesForRegistration = new List<Type>();
            foreach (var assembly in assemblies)
            {
                typesForRegistration.AddRange(assembly
                    .GetTypes()
                    .Where(x => x.GetInterfaces().Any(contracts.Contains))
                    .ToList());
            }

            foreach (var type in typesForRegistration)
            {
                services.AddScoped(type);
            }
        }
    }
}