using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Utilities.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent
{
    public class VueStaticContentModule : VueScaffoldModule
    {
        public VueStaticContentModule()
            : base("Vue Static Content", true)
        {

        }

        public override void DefineFiles()
        {
            string relativePath = Path.Combine(Options.WebAppPath, VueAppFolders.Components, VueAppFolders.StaticContent);
            var localizationContext = GetService<ILocalizationContext>();

            var contentKeys = localizationContext
                .ContentKeys
                .ToList();

            foreach (var contentKey in contentKeys)
            {
                AddFile(new ModuleFile
                {
                    Name = $"{string.Join(string.Empty, contentKey.Key.Split("_").Select(x => x.ToLower().ToFirstUpper()))}StaticContent.vue",
                    RelativePath = relativePath,
                    TemplateType = typeof(StaticContentComponentTemplate),
                    ReferenceId = contentKey.Id.ToString(),
                    RenderFunction = RenderStaticContent
                });
            }
        }

        public override void DefineFolders()
        {
            string relativePath = Path.Combine(Options.WebAppPath, VueAppFolders.Components);
            AddFolder(new ModuleFolder
            {
                Name = VueAppFolders.StaticContent,
                RelativePath = relativePath
            });
        }

        private string RenderStaticContent(ModuleFile file)
        {
            var localizationContext = GetService<ILocalizationContext>();
            Language defaultLanguage = localizationContext.Languages.FirstOrDefault(x => x.IsDefault);
            ContentKey staticContentKeyWithContent = localizationContext
                .ContentKeys
                .Where(x => x.Id == int.Parse(file.ReferenceId))
                .Include(x => x.StaticContentList)
                .FirstOrDefault();

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Key", staticContentKeyWithContent },
                { "DefaultLanguage", defaultLanguage }
            });
        }
    }
}
