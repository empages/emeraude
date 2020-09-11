using Definux.Emeraude.Application.Common.Mapping;
using System.Reflection;

namespace EmDoggoDev.Application.Common.Mapping
{
    public class EmDoggoDevAssemblyMappingProfile : AssemblyMappingProfile
    {
        public EmDoggoDevAssemblyMappingProfile()
            : base(Assembly.GetExecutingAssembly())
        {

        }
    }
}
