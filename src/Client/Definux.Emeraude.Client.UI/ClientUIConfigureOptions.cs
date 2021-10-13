using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Client.UI
{
    /// <summary>
    /// Client UI options that configure the static files loaded in the assembly.
    /// </summary>
    public class ClientUIConfigureOptions : UIConfigureOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUIConfigureOptions"/> class.
        /// </summary>
        /// <param name="environment"></param>
        public ClientUIConfigureOptions(IHostingEnvironment environment)
            : base(environment)
        {
        }
    }
}
