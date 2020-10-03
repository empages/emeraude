using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude
{
    /// <summary>
    /// Static class that provides access to the Emeraude asembly information.
    /// </summary>
    public static class ApplicationAssemblyPart
    {
        /// <inheritdoc cref="System.Reflection.Assembly"/>
        public static Assembly Assembly
        {
            get
            {
                return typeof(ApplicationAssemblyPart).GetType().GetTypeInfo().Assembly;
            }
        }

        /// <inheritdoc cref="Microsoft.AspNetCore.Mvc.ApplicationParts.AssemblyPart"/>
        public static AssemblyPart AssemblyPart
        {
            get
            {
                return new AssemblyPart(Assembly);
            }
        }
    }
}
