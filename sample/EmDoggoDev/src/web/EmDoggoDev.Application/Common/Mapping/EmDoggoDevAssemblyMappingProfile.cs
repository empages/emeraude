using Definux.Emeraude.Application.Common.Mapping;
using System.Reflection;

namespace EmDoggoDev.Application.Common.Mapping
{
    /// <summary>
    /// Assembly mapping profile for registration of all mappings configurations for EmPages.
    /// </summary>
    public class EmDoggoDevAssemblyMappingProfile : AssemblyMappingProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmDoggoDevAssemblyMappingProfile"/> class.
        /// </summary>
        public EmDoggoDevAssemblyMappingProfile()
            : base(Assembly.GetExecutingAssembly())
        {

        }
    }
}
