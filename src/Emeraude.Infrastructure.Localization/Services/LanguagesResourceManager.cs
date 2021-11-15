using System;
using System.IO;
using System.Resources;
using Emeraude.Essentials.Base;
using Emeraude.Infrastructure.FileStorage.Services;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.Localization.Services
{
    /// <inheritdoc cref="ILanguagesResourceManager"/>
    public class LanguagesResourceManager : ILanguagesResourceManager
    {
        private const string ResourceNameFormat = "Translations.{0}.resources";

        private readonly ILanguageStore languageStore;
        private readonly IRootsService rootsService;
        private readonly ISystemFilesService systemFilesService;
        private readonly ILogger<LanguagesResourceManager> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesResourceManager"/> class.
        /// </summary>
        /// <param name="languageStore"></param>
        /// <param name="rootsService"></param>
        /// <param name="systemFilesService"></param>
        /// <param name="logger"></param>
        public LanguagesResourceManager(
            ILanguageStore languageStore,
            IRootsService rootsService,
            ISystemFilesService systemFilesService,
            ILogger<LanguagesResourceManager> logger)
        {
            this.languageStore = languageStore;
            this.rootsService = rootsService;
            this.systemFilesService = systemFilesService;
            this.logger = logger;
        }

        /// <inheritdoc />
        public void BuildResources()
        {
            var languages = this.languageStore.GetLanguages();
            this.systemFilesService.CreateFolder(EmFolders.ResourcesFolderName, this.rootsService.PrivateRootDirectory);

            foreach (var language in languages)
            {
                var translations = this.languageStore.GetLanguageTranslationDictionary(language.Id);
                string languageTranslationsResourcesPath = this.rootsService.GetPathFromPrivateRoot(EmFolders.ResourcesFolderName, string.Format(ResourceNameFormat, language.Code));
                using (ResourceWriter resourceWriter = new ResourceWriter(languageTranslationsResourcesPath))
                {
                    foreach (var (key, value) in translations)
                    {
                        resourceWriter.AddResource(key.Trim(), value?.Trim() ?? string.Empty);
                    }
                }
            }
        }

        /// <inheritdoc />
        public string GetTranslationResource(string translationKey, string languageCode)
        {
            try
            {
                using var resourceReader = new ResourceReader(this.rootsService.GetPathFromPrivateRoot(EmFolders.ResourcesFolderName, string.Format(ResourceNameFormat, languageCode)));
                resourceReader.GetResourceData(translationKey, out _, out var translationBytes);
                using var memoryStream = new MemoryStream(translationBytes);
                using var binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadString();
            }
            catch (Exception)
            {
                this.logger.LogWarning("There is not found {Language} translation for key: '{TranslationKey}'", languageCode, translationKey);
                return null;
            }
        }
    }
}