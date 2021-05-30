using Definux.Emeraude.Admin.UI;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Admin.ClientBuilder.UI
{
    /// <inheritdoc cref="AdminUIConfigureOptions"/>
    public class AdminClientBuilderUIConfigureOptions : AdminUIConfigureOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminClientBuilderUIConfigureOptions"/> class.
        /// </summary>
        /// <param name="environment"></param>
        public AdminClientBuilderUIConfigureOptions(IHostingEnvironment environment)
            : base(environment)
        {
        }
    }
}
