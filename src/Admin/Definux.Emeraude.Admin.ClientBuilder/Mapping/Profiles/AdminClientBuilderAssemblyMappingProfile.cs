using Definux.Emeraude.Application.Mapping;

namespace Definux.Emeraude.Admin.ClientBuilder.Mapping.Profiles
{
    /// <summary>
    /// Assembly mapping profile for registration of all mappings configurations for client builder.
    /// </summary>
    public class AdminClientBuilderAssemblyMappingProfile : AssemblyMappingProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminClientBuilderAssemblyMappingProfile"/> class.
        /// </summary>
        public AdminClientBuilderAssemblyMappingProfile()
            : base(System.Reflection.Assembly.GetExecutingAssembly())
        {
        }
    }
}
