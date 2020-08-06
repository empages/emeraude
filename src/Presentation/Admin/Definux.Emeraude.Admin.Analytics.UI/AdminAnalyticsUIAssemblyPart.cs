using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Reflection;

namespace Definux.Emeraude.Admin.Analytics.UI
{
    public static class AdminAnalyticsUIAssemblyPart
    {
        public static Assembly Assembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        public static CompiledRazorAssemblyPart AssemblyPart
        {
            get
            {
                return new CompiledRazorAssemblyPart(Assembly);
            }
        }
    }
}
