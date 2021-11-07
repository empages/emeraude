using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Definux.Emeraude.Infrastructure.Localization")]
[assembly: ComVisible(false)]

namespace Definux.Emeraude.Infrastructure.Localization
{
    /// <summary>
    /// Assembly info provider.
    /// </summary>
    public static class AssemblyInfo
    {
        /// <summary>
        /// Gets execution assembly.
        /// </summary>
        /// <returns></returns>
        public static Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}