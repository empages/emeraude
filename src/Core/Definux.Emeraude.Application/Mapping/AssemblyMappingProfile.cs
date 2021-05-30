using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Definux.Emeraude.Application.Mapping
{
    /// <summary>
    /// Abstract assembly mapping profile for registration of all mappings configurations.
    /// </summary>
    public abstract class AssemblyMappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyMappingProfile"/> class.
        /// </summary>
        /// <param name="assembly"></param>
        public AssemblyMappingProfile(Assembly assembly)
        {
            this.ApplyMappingsFromAssembly(assembly);
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly
                .GetExportedTypes()
                .Where(x => x.GetInterfaces().Any(y => y.IsGenericType && y.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping") ?? type.GetInterface("IMapFrom`1").GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
