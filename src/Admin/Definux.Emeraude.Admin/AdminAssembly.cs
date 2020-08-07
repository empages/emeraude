using System.Reflection;

namespace Definux.Emeraude.Admin
{
    public static class AdminAssembly
    {
        public static Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}
