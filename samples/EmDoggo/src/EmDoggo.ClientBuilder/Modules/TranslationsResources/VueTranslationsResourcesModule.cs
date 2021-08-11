using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Domain.Localization;
using EmDoggo.ClientBuilder.Modules.TranslationsResources.Templates;
using EmDoggo.ClientBuilder.Shared;
using Newtonsoft.Json;

namespace EmDoggo.ClientBuilder.Modules.TranslationsResources
{
    /// <summary>
    /// Vue translation resources module for generation of all files (JSON) that contains the translations + their load i18n script in Vue application.
    /// </summary>
    public class VueTranslationsResourcesModule : VueScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VueTranslationsResourcesModule"/> class.
        /// </summary>
        public VueTranslationsResourcesModule()
            : base("Vue Translations Resources", true)
        {
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            var languageStore = this.GetService<ILanguageStore>();
            var languages = languageStore.GetLanguages();
            string relativePath = Path.Combine(this.Options.GetVueClientAppPath(), VueAppFolders.Locales);

            foreach (var language in languages)
            {
                this.AddFile(new ModuleFile
                {
                    Name = $"{language.Code.ToLower()}.json",
                    RelativePath = relativePath,
                    ReferenceId = language.Id.ToString(),
                    RenderFunction = this.RenderLanguageJson,
                });
            }

            this.AddFile(new ModuleFile
            {
                Name = $"i18n.js",
                RelativePath = relativePath,
                ReferenceId = "config",
                RenderFunction = this.RenderConfigFile,
                TemplateType = typeof(I18nConfigTemplate),
            });
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
            this.AddFolder(new ModuleFolder
            {
                Name = VueAppFolders.Locales,
                RelativePath = this.Options.GetVueClientAppPath(),
            });
        }

        private string RenderLanguageJson(ModuleFile file)
        {
            var languageStore = this.GetService<ILanguageStore>();
            int languageId = int.Parse(file.ReferenceId);
            var translationsDictionary = languageStore.GetLanguageTranslationDictionary(languageId);

            return JsonConvert.SerializeObject(translationsDictionary);
        }

        private string RenderConfigFile(ModuleFile file)
        {
            var localizationContext = this.GetService<ILocalizationContext>();
            var languages = localizationContext.Languages.ToList();
            Language defaultLanguage = languages.FirstOrDefault(x => x.IsDefault);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Languages", languages },
                { "DefaultLanguage", defaultLanguage },
            });
        }
    }
}
