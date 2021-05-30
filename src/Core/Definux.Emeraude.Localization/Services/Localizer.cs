using System;
using System.Linq;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Localizer"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        /// <param name="currentLanguageProvider"></param>
        public Localizer(ILocalizationContext context, IEmLogger logger, ICurrentLanguageProvider currentLanguageProvider)
        {
            this.context = context;
            this.logger = logger;
            this.currentLanguageProvider = currentLanguageProvider;
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
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.ContentKey.Key == key)
                    .FirstOrDefault()?.Content;

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
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.ContentKey.Key == key)
                    .FirstOrDefault()?.Content;

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
                string languageCode = this.currentLanguageProvider.GetCurrentLanguage()?.Code;
                string content = (await this.context
                    .StaticContent
                    .AsQueryable()
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
                    .AsQueryable()
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
                string languageCode = this.currentLanguageProvider.GetCurrentLanguage()?.Code;
                string value = this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.TranslationKey.Key == key)
                    .FirstOrDefault()?.Value;

                return string.IsNullOrEmpty(value) ? key : value;
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
                string value = this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.TranslationKey.Key == key)
                    .FirstOrDefault()?.Value;

                return string.IsNullOrEmpty(value) ? key : value;
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
                string value = (await this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.TranslationKey.Key == key)
                    .FirstOrDefaultAsync())?.Value;

                return string.IsNullOrEmpty(value) ? key : value;
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
                string value = (await this.context
                    .Values
                    .AsQueryable()
                    .Where(x => x.Language.Code.ToLower() == languageCode.ToLower() && x.TranslationKey.Key == key)
                    .FirstOrDefaultAsync())?.Value;

                return string.IsNullOrEmpty(value) ? key : value;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
                return key;
            }
        }
    }
}
