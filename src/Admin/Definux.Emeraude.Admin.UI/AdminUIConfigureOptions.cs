using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.UI
{
    /// <summary>
    /// Admin UI options that configure the static files loaded in the assembly.
    /// </summary>
    public class AdminUIConfigureOptions : IPostConfigureOptions<StaticFileOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUIConfigureOptions"/> class.
        /// </summary>
        /// <param name="environment"></param>
        public AdminUIConfigureOptions(IHostingEnvironment environment)
        {
            this.Environment = environment;
        }

        /// <inheritdoc cref="IHostingEnvironment"/>
        public IHostingEnvironment Environment { get; }

        /// <inheritdoc/>
        public void PostConfigure(string name, StaticFileOptions options)
        {
            name = name ?? throw new ArgumentNullException(nameof(name));
            options = options ?? throw new ArgumentNullException(nameof(options));

            // Basic initialization in case the options weren't initialized by any other component
            options.ContentTypeProvider = options.ContentTypeProvider ?? new FileExtensionContentTypeProvider();
            if (options.FileProvider == null && this.Environment.WebRootFileProvider == null)
            {
                throw new InvalidOperationException("Missing FileProvider.");
            }

            options.FileProvider = options.FileProvider ?? this.Environment.WebRootFileProvider;

            // Add our provider
            var filesProvider = new ManifestEmbeddedFileProvider(this.GetType().Assembly, "wwwroot");
            options.FileProvider = new CompositeFileProvider(options.FileProvider, filesProvider);
        }
    }
}
