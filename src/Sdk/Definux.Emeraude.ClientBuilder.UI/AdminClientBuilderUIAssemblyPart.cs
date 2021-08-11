using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.ClientBuilder.UI
{
    /// <summary>
    /// Static class that provides access to the Admin Client Builder UI assembly information.
    /// </summary>
    public static class AdminClientBuilderUIAssemblyPart
    {
        /// <inheritdoc cref="System.Reflection.Assembly"/>
        public static Assembly Assembly => Assembly.GetExecutingAssembly();

        /// <inheritdoc cref="CompiledRazorAssemblyPart"/>
        public static CompiledRazorAssemblyPart AssemblyPart => new CompiledRazorAssemblyPart(Assembly);
    }
}
