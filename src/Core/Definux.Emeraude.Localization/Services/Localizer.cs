using System;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Localization.Services
{
    /// <inheritdoc cref="ILocalizer"/>
    public class Localizer : IEmLocalizer
    {
        private readonly ILocalizationContext context;
        private readonly IEmLogger logger;
        private readonly ICurrentLanguageProvider currentLanguageProvider;
        private readonly ILanguagesResourceManager languagesResourceManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="Localizer"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        /// <param name="currentLanguageProvider"></param>
        /// <param name="languagesResourceManager"></param>
        public Localizer(
            ILocalizationContext context,
            IEmLogger logger,
            ICurrentLanguageProvider currentLanguageProvider,
            ILanguagesResourceManager languagesResourceManager)
        {
            this.context = context;
            this.logger = logger;
            this.currentLanguageProvider = currentLanguageProvider;
            this.languagesResourceManager = languagesResourceManager;
        }

        /// <inheritdoc/>
        public string this[string key] => this.TranslateKey(key);

        /// <inheritdoc/>
        public string GetStaticContent(string key)
        {
            try
            {
                string languageCode = this.currentLanguageProvider.GetCurrentLanguage()?.Code;
                string content = this.context
                    .StaticContent
                    .FirstOrDefault(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.ContentKey.Key == key)
                    ?.Content;

                return string.IsNullOrEmpty(content) ? key : content;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return key;
            }
        }

        /// <inheritdoc/>
        public string GetStaticContent(string key, string languageCode)
        {
            try
            {
                string content = this.context
                    .StaticContent
                    .FirstOrDefault(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.ContentKey.Key == key)
                    ?.Content;

                return string.IsNullOrEmpty(content) ? key : content;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return key;
            }
        }

        /// <inheritdoc/>
        public async Task<string> GetStaticContentAsync(string key)
        {
            try
            {
                string languageCode = (await this.currentLanguageProvider.GetCurrentLanguageAsync())?.Code;
                string content = (await this.context
                    .StaticContent
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.ContentKey.Key == key)
                    .FirstOrDefaultAsync())?.Content;

                return string.IsNullOrEmpty(content) ? key : content;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return key;
            }
        }

        /// <inheritdoc/>
        public async Task<string> GetStaticContentAsync(string key, string languageCode)
        {
            try
            {
                string content = (await this.context
                    .StaticContent
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.ContentKey.Key == key)
                    .FirstOrDefaultAsync())?.Content;

                return string.IsNullOrEmpty(content) ? key : content;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return key;
            }
        }

        /// <inheritdoc/>
        public string TranslateKey(string key)
        {
            try
            {
                var languageCode = this.currentLanguageProvider.GetCurrentLanguage()?.Code;
                return this.TranslateKeyAction(key, languageCode);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return key;
            }
        }

        /// <inheritdoc/>
        public string TranslateKey(string key, string languageCode)
        {
            try
            {
                return this.TranslateKeyAction(key, languageCode);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return key;
            }
        }

        /// <inheritdoc/>
        public async Task<string> TranslateKeyAsync(string key)
        {
            try
            {
                string languageCode = (await this.currentLanguageProvider.GetCurrentLanguageAsync())?.Code;
                return this.TranslateKeyAction(key, languageCode);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return key;
            }
        }

        /// <inheritdoc/>
        public async Task<string> TranslateKeyAsync(string key, string languageCode)
        {
            try
            {
                return this.TranslateKeyAction(key, languageCode);
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return key;
            }
        }

        private string TranslateKeyAction(string key, string languageCode)
        {
            string value = this.languagesResourceManager.GetTranslationResource(key, languageCode);
            return string.IsNullOrEmpty(value) ? key : value;
        }
    }
}
