using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Emeraude.Infrastructure.Persistence")]
[assembly: ComVisible(false)]

namespace Emeraude.Infrastructure.Persistence.Properties
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