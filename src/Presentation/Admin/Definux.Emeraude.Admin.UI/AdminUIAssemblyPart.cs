using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Reflection;

namespace Definux.Emeraude.Admin.UI
{
    public static class AdminUIAssemblyPart
    {
        public static Assembly Assembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        public static CompiledRazorAssemblyPart AssemblyPart
        {
            get
            {
                return new CompiledRazorAssemblyPart(Assembly);
            }
        }
    }
}
