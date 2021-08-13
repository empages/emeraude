using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Configuration.Abstractions
{
    /// <summary>
    /// UI options that configure the static files loaded in the assembly.
    /// </summary>
    public class UIConfigureOptions : IPostConfigureOptions<StaticFileOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UIConfigureOptions"/> class.
        /// </summary>
        /// <param name="environment"></param>
        public UIConfigureOptions(IHostingEnvironment environment)
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

            options.ContentTypeProvider = options.ContentTypeProvider ?? new FileExtensionContentTypeProvider();
            if (options.FileProvider == null && this.Environment.WebRootFileProvider == null)
            {
                throw new InvalidOperationException("Missing FileProvider.");
            }

            options.FileProvider = options.FileProvider ?? this.Environment.WebRootFileProvider;
            var filesProvider = new ManifestEmbeddedFileProvider(this.GetType().Assembly, "wwwroot");
            options.FileProvider = new CompositeFileProvider(options.FileProvider, filesProvider);
        }
    }
}
