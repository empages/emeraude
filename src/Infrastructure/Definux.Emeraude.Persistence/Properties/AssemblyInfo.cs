using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Definux.Emeraude.Data")]
[assembly: ComVisible(false)]

namespace Definux.Emeraude.Data
{
    public static class AssemblyInfo
    {
        public static Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}