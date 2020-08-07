using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Definux.Emeraude.Localization")]
[assembly: ComVisible(false)]

namespace Definux.Emeraude.Localization
{
    public static class AssemblyInfo
    {
        public static Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}