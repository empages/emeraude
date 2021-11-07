using Definux.Emeraude.Application.Mapping;

namespace Definux.Emeraude.Application.Admin.Mapping.Profiles
{
    /// <summary>
    /// Assembly mapping profile for registration of all mappings configurations for administration.
    /// </summary>
    public class AdminAssemblyMappingProfile : AssemblyMappingProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAssemblyMappingProfile"/> class.
        /// </summary>
        public AdminAssemblyMappingProfile()
            : base(System.Reflection.Assembly.GetExecutingAssembly())
        {
        }
    }
}
