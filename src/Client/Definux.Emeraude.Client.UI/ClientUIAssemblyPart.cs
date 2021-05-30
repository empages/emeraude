using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.Client.UI
{
    /// <summary>
    /// Static class that provides access to the Client UI assembly information.
    /// </summary>
    public static class ClientUIAssemblyPart
    {
        /// <inheritdoc cref="System.Reflection.Assembly"/>
        public static Assembly Assembly => Assembly.GetExecutingAssembly();

        /// <inheritdoc cref="CompiledRazorAssemblyPart"/>
        public static CompiledRazorAssemblyPart AssemblyPart => new CompiledRazorAssemblyPart(Assembly);
    }
}
