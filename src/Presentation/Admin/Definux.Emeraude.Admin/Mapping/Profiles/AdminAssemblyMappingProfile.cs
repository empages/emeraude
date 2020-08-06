using Definux.Emeraude.Application.Common.Mapping;

namespace Definux.Emeraude.Admin.Mapping.Profiles
{
    public class AdminAssemblyMappingProfile : AssemblyMappingProfile
    {
        public AdminAssemblyMappingProfile()
            : base(System.Reflection.Assembly.GetExecutingAssembly())
        {

        }
    }
}
