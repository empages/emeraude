using Definux.Emeraude.Application.Mapping;
using System.Reflection;

namespace Definux.Emeraude.Tests.Project.Application.Mapping
{
    public class MainAssemblyMappingProfile : AssemblyMappingProfile
    {
        public MainAssemblyMappingProfile()
            : base(Assembly.GetExecutingAssembly())
        {

        }
    }
}
