using System.Reflection;
using Emeraude.Application.Mapping;

namespace EmDoggo.Application.Mapping;

public class EmDoggoAssemblyMappingProfile : AssemblyMappingProfile
{
    public EmDoggoAssemblyMappingProfile()
        : base(Assembly.GetExecutingAssembly())
    {
    }
}