using System.Collections.Generic;
using System.IO;
using System.Linq;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Emeraude.Application.Localization;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources
{
    /// <summary>
    /// Xamarin translation resources module for generation of all localization resources based on localization context in Xamarin application.
    /// </summary>
    public class XamarinTranslationsResourcesModule : XamarinScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XamarinTranslationsResourcesModule"/> class.
        /// </summary>
        public XamarinTranslationsResourcesModule()
            : base("Xamarin Translations Resources", true)
        {
        }

        /// <inheritdoc/>
        public override void DefineFiles()
        {
            var languageStore = this.GetService<ILanguageStore>();
            var languages = languageStore.GetLanguages();
            string relativePath = Path.Combine(this.Options.MobileAppPath, XamarinAppFolders.Translations);

            this.AddFile(new ModuleFile
            {
                Name = $"EmeraudeTranslationKeys.cs",
                RelativePath = Path.Combine(relativePath),
                TemplateType = typeof(TranslationsKeysTemplate),
                RenderFunction = this.RenderTranslationsKeys,
            });

            this.AddFile(new ModuleFile
            {
                Name = $"Translations.resx",
                RelativePath = Path.Combine(relativePath),
                TemplateType = typeof(TranslationsTemplate),
                RenderFunction = this.RenderTranslationsBase,
            });

            foreach (var language in languages)
            {
                this.AddFile(new ModuleFile
                {
                    Name = $"Translations.{language.Code.ToLower()}.resx",
                    RelativePath = Path.Combine(relativePath),
                    ReferenceId = language.Id.ToString(),
                    TemplateType = typeof(TranslationsTemplate),
                    RenderFunction = this.RenderTranslations,
                });
            }
        }

        /// <inheritdoc/>
        public override void DefineFolders()
        {
            this.AddFolder(new ModuleFolder
            {
                Name = XamarinAppFolders.Translations,
                RelativePath = this.Options.MobileAppPath,
            });
        }

        private string RenderTranslationsBase(ModuleFile file)
        {
            var languageStore = this.GetService<ILanguageStore>();
            var defaultLanguage = languageStore.GetDefaultLanguage();
            var translationsDictionary = languageStore.GetLanguageTranslationDictionary(defaultLanguage.Id);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Translations", translationsDictionary },
            });
        }

        private string RenderTranslations(ModuleFile file)
        {
            var languageStore = this.GetService<ILanguageStore>();
            var translationsDictionary = languageStore.GetLanguageTranslationDictionary(int.Parse(file.ReferenceId));

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Translations", translationsDictionary },
            });
        }

        private string RenderTranslationsKeys(ModuleFile file)
        {
            var languageStore = this.GetService<ILanguageStore>();
            var translationsKeys = languageStore.GetTranslationsKeys();
            var translationsKeysDictionary = translationsKeys.ToDictionary(k => this.MakePascalCaseKeyFromTranslationKey(k), v => v);

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "TranslationsKeys", translationsKeysDictionary },
            });
        }

        private string MakePascalCaseKeyFromTranslationKey(string translationKey)
        {
            var keyWords = translationKey.Split('_');
            int wordsAmount = keyWords.Length;
            for (int i = 0; i < wordsAmount; i++)
            {
                keyWords[i] = keyWords[i].ToLower().ToFirstUpper();
            }

            return string.Join(string.Empty, keyWords);
        }
    }
}
