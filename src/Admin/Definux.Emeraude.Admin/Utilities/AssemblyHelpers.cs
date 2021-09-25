using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Definux.Emeraude.Admin.Utilities
{
    /// <summary>
    /// Assembly helper methods.
    /// </summary>
    public static class AssemblyHelpers
    {
        /// <summary>
        /// Returns list of all types that implements specified interface from collection of assemblies.
        /// </summary>
        /// <param name="assemblies"></param>
        /// <typeparam name="TInterface">Type of the interface.</typeparam>
        /// <returns></returns>
        public static IEnumerable<Type> GetClassesThatImplements<TInterface>(IEnumerable<Assembly> assemblies) =>
            GetClassesThatImplements(typeof(TInterface), assemblies);

        /// <summary>
        /// Returns list of all types that implements specified interface and collection of assemblies.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="assemblies"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetClassesThatImplements(Type type, IEnumerable<Assembly> assemblies) =>
            assemblies
                .SelectMany(x => x.GetTypes())
                .Where(x => x.IsClass && x.GetInterfaces().Any(xx => xx == type))
                .ToList();
    }
}