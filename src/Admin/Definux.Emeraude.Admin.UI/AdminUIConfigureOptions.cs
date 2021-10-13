using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Admin.UI
{
    /// <summary>
    /// Admin UI options that configure the static files loaded in the assembly.
    /// </summary>
    public class AdminUIConfigureOptions : UIConfigureOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUIConfigureOptions"/> class.
        /// </summary>
        /// <param name="environment"></param>
        public AdminUIConfigureOptions(IHostingEnvironment environment)
            : base(environment)
        {
        }
    }
}
