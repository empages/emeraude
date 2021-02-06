using System.Reflection;
using Definux.Emeraude.Application.Mapping;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Mapping
{
    public class TestAssemblyMappingProfile : AssemblyMappingProfile
    {
        public TestAssemblyMappingProfile()
            : base(Assembly.GetExecutingAssembly())
        {

        }
    }
}
