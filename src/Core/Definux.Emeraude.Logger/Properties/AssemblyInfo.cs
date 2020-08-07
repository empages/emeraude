using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Definux.Emeraude.Logger")]
[assembly: ComVisible(false)]

namespace Definux.Emeraude.Logger
{
    public static class AssemblyInfo
    {
        public static Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}