using Definux.Emeraude.Application.Mapping;
using System.Reflection;

namespace EmDoggo.Application.Mapping
{
    /// <summary>
    /// Assembly mapping profile for registration of all mappings configurations for EmPages.
    /// </summary>
    public class EmDoggoAssemblyMappingProfile : AssemblyMappingProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmDoggoAssemblyMappingProfile"/> class.
        /// </summary>
        public EmDoggoAssemblyMappingProfile()
            : base(Assembly.GetExecutingAssembly())
        {

        }
    }
}
