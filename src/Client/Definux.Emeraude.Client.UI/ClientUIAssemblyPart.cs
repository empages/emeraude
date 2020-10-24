using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.Client.UI
{
    /// <summary>
    /// Static class that provides access to the Client UI asembly information.
    /// </summary>
    public static class ClientUIAssemblyPart
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
