using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.Admin.Analytics.UI
{
    /// <summary>
    /// Static class that provides access to the Admin Analytics UI asembly information.
    /// </summary>
    public static class AdminAnalyticsUIAssemblyPart
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
