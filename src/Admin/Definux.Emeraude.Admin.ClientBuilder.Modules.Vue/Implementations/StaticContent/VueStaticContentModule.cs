using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Utilities.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent
{
    /// <summary>
    /// Vue static content module for generation of components that represent the static content entities from the localization context in Vue application.
    /// </summary>
    public class VueStaticContentModule : VueScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VueStaticContentModule"/> class.
        /// </summary>
        public VueStaticContentModule()
            : base("Vue Static Content", true)
        {
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            string relativePath = Path.Combine(this.Options.WebAppPath, VueAppFolders.Components, VueAppFolders.StaticContent);
            var localizationContext = this.GetService<ILocalizationContext>();

            var contentKeys = localizationContext
                .ContentKeys
                .ToList();

            foreach (var contentKey in contentKeys)
            {
                this.AddFile(new ModuleFile
                {
                    Name = $"{string.Join(string.Empty, contentKey.Key.Split("_").Select(x => x.ToLower().ToFirstUpper()))}StaticContent.vue",
                    RelativePath = relativePath,
                    TemplateType = typeof(StaticContentComponentTemplate),
                    ReferenceId = contentKey.Id.ToString(),
                    RenderFunction = this.RenderStaticContent,
                });
            }
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
            string relativePath = Path.Combine(this.Options.WebAppPath, VueAppFolders.Components);
            this.AddFolder(new ModuleFolder
            {
                Name = VueAppFolders.StaticContent,
                RelativePath = relativePath,
            });
        }

        private string RenderStaticContent(ModuleFile file)
        {
            var localizationContext = this.GetService<ILocalizationContext>();
            Language defaultLanguage = localizationContext.Languages.FirstOrDefault(x => x.IsDefault);
            ContentKey staticContentKeyWithContent = localizationContext
                .ContentKeys
                .Where(x => x.Id == int.Parse(file.ReferenceId))
                .Include(x => x.StaticContentList)
                .FirstOrDefault();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Key", staticContentKeyWithContent },
                { "DefaultLanguage", defaultLanguage },
            });
        }
    }
}
