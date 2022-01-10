using System.Reflection;
using Emeraude.Application.Mapping;

namespace EmDoggo.Admin.Mapping;

public class EmDoggoAdminAssemblyMappingProfile : AssemblyMappingProfile
{
    public EmDoggoAdminAssemblyMappingProfile()
        : base(Assembly.GetExecutingAssembly())
    {
    }
}