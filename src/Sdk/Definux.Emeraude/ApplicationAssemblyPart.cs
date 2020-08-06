using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Reflection;

namespace Definux
{
    public static class ApplicationAssemblyPart
    {
        public static Assembly Assembly
        {
            get
            {
                return typeof(ApplicationAssemblyPart).GetType().GetTypeInfo().Assembly;
            }
        }

        public static AssemblyPart AssemblyPart
        {
            get
            {
                return new AssemblyPart(Assembly);
            }
        }
    }
}
