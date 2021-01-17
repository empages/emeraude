using System.Collections.Generic;
using System.IO;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Services;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages
{
    /// <summary>
    /// Vue EmPages module for generation of all pages components for created EmPages in Vue application.
    /// The generation of this module is executing once in case when the page does not exist.
    /// </summary>
    public class VueEmPagesModule : VueScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VueEmPagesModule"/> class.
        /// </summary>
        public VueEmPagesModule()
            : base("Vue EmPages", false)
        {
            this.Order = 20;
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            var pageService = this.GetService<IPageService>();
            var pages = pageService.GetAllPages();
            string relativePath = Path.Combine(this.Options.WebAppPath, VueAppFolders.Pages);

            foreach (var page in pages)
            {
                string currentPageFolderName = page.Name;

                this.AddFile(new ModuleFile
                {
                    Name = "index.vue",
                    RelativePath = Path.Combine(relativePath, currentPageFolderName),
                    TemplateType = typeof(ComponentTemplate),
                    ReferenceId = page.FullName,
                    RenderFunction = this.RenderPageComponent,
                });
            }
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
            string relativePath = Path.Combine(this.Options.WebAppPath, VueAppFolders.Pages);
            var pageService = this.GetService<IPageService>();
            var pages = pageService.GetAllPages();

            foreach (var page in pages)
            {
                this.AddFolder(new ModuleFolder
                {
                    Name = page.Name,
                    RelativePath = relativePath,
                });
            }
        }

        private string RenderPageComponent(ModuleFile file)
        {
            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Page", file.ReferenceId },
            });
        }
    }
}