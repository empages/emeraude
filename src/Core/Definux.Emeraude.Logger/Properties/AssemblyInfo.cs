using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Definux.Emeraude.Logger")]
[assembly: ComVisible(false)]

namespace Definux.Emeraude.Logger
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