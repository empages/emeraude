using Definux.Emeraude.Application.Common.Mapping;

namespace Definux.Emeraude.Admin.ClientBuilder.Mapping.Profiles
{
    public class AdminClientBuilderAssemblyMappingProfile : AssemblyMappingProfile
    {
        public AdminClientBuilderAssemblyMappingProfile()
            : base(System.Reflection.Assembly.GetExecutingAssembly())
        {

        }
    }
}
