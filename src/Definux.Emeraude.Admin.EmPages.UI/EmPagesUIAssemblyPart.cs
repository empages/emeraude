using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.Admin.EmPages.UI
{
    /// <summary>
    /// Static class that provides access to the Admin UI assembly information.
    /// </summary>
    public static class EmPagesUIAssemblyPart
    {
        /// <inheritdoc cref="System.Reflection.Assembly"/>
        public static Assembly Assembly => Assembly.GetExecutingAssembly();

        /// <inheritdoc cref="CompiledRazorAssemblyPart"/>
        public static CompiledRazorAssemblyPart AssemblyPart => new CompiledRazorAssemblyPart(Assembly);
    }
}
