using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.Admin.UI
{
    /// <summary>
    /// Static class that provides access to the Admin UI asembly information.
    /// </summary>
    public static class AdminUIAssemblyPart
    {
        /// <inheritdoc cref="System.Reflection.Assembly"/>
        public static Assembly Assembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        /// <inheritdoc cref="CompiledRazorAssemblyPart"/>
        public static CompiledRazorAssemblyPart AssemblyPart
        {
            get
            {
                return new CompiledRazorAssemblyPart(Assembly);
            }
        }
    }
}
