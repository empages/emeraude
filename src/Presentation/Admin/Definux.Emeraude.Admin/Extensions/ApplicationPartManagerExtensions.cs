using Definux.Emeraude.Admin.Analytics.UI;
using Definux.Emeraude.Admin.ClientBuilder.UI;
using Definux.Emeraude.Admin.UI;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.Admin.Extensions
{
    public static class ApplicationPartManagerExtensions
    {
        public static ApplicationPartManager AddAdminUIApplicationParts(this ApplicationPartManager applicationPartManager)
        {
            applicationPartManager.ApplicationParts.Add(AdminUIAssemblyPart.AssemblyPart);
            applicationPartManager.ApplicationParts.Add(AdminClientBuilderUIAssemblyPart.AssemblyPart);
            applicationPartManager.ApplicationParts.Add(AdminAnalyticsUIAssemblyPart.AssemblyPart);

            return applicationPartManager;
        }
    }
}