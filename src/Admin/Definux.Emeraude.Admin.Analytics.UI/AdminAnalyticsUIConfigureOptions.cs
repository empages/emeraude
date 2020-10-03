using Definux.Emeraude.Admin.UI;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Admin.Analytics.UI
{
    /// <inheritdoc cref="AdminUIConfigureOptions"/>
    public class AdminAnalyticsUIConfigureOptions : AdminUIConfigureOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAnalyticsUIConfigureOptions"/> class.
        /// </summary>
        /// <param name="environment"></param>
        public AdminAnalyticsUIConfigureOptions(IHostingEnvironment environment)
            : base(environment)
        {
        }
    }
}
