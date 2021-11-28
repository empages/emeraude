using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Localization.Persistence;
using Emeraude.Infrastructure.Localization.Persistence.Entities;
using Emeraude.Infrastructure.Localization.Services;
using Emeraude.Tests.Base;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Emeraude.Tests.Infrastructure.Tests
{
    public class LanguageStoreTests
    {
        private readonly ILocalizationContext localizationContext;
        
        public LanguageStoreTests()
        {
            this.localizationContext = new TestsDatabaseContextBuilder<LocalizationContext>().Build();
        }

        [Fact]
        public async Task GetAllLanguageCodes_OnCorrectData_ShouldReturnCorrectResult()
        {
            await PopulateDataAsync();
            var languageStore = GetSubject();
            
            var resultLanguageCodes = languageStore.GetAllLanguageCodes();
            resultLanguageCodes.Should().BeEquivalentTo(new[] { "en", "bg" });
        }
        
        [Fact]
        public void GetAllLanguageCodes_OnNoData_ShouldReturnEmptyResult()
        {
            var languageStore = GetSubject();
            
            var resultLanguageCodes = languageStore.GetAllLanguageCodes();
            resultLanguageCodes.Length.Should().Be(0);
        }
        
        [Fact]
        public async Task GetAllLanguageCodesAsync_OnCorrectData_ShouldReturnCorrectResult()
        {
            await PopulateDataAsync();
            var languageStore = GetSubject();
            
            var resultLanguageCodes = await languageStore.GetAllLanguageCodesAsync();
            resultLanguageCodes.Should().BeEquivalentTo(new[] { "en", "bg" });
        }

        [Fact]
        public async Task GetAllLanguageCodesAsync_OnNoData_ShouldReturnEmptyResult()
        {
            var languageStore = GetSubject();

            var resultLanguageCodes = await languageStore.GetAllLanguageCodesAsync();
            resultLanguageCodes.Length.Should().Be(0);
        }

        [Fact]
        public async Task GetDefaultLanguage_OnCorrectData_ShouldReturnCorrectResult()
        {
            await PopulateDataAsync();
            var languageStore = GetSubject();

            var defaultLanguage = languageStore.GetDefaultLanguage();
            defaultLanguage.Id.Should().Be(1);
        }
        
        [Fact]
        public void GetDefaultLanguage_OnNoData_ShouldReturnEmptyResult()
        {
            var languageStore = GetSubject();

            var defaultLanguage = languageStore.GetDefaultLanguage();
            Assert.Null(defaultLanguage);
        }

        [Fact]
        public async Task GetDefaultLanguageAsync_OnCorrectData_ShouldReturnCorrectResult()
        {
            await PopulateDataAsync();
            var languageStore = GetSubject();

            var defaultLanguage = await languageStore.GetDefaultLanguageAsync();
            defaultLanguage.Id.Should().Be(1);
        }
        
        [Fact]
        public async Task GetDefaultLanguageAsync_OnNoData_ShouldReturnEmptyResult()
        {
            var languageStore = GetSubject();

            var defaultLanguage = await languageStore.GetDefaultLanguageAsync();
            Assert.Null(defaultLanguage);
        }
        
        [Fact]
        public async Task GetLanguages_OnCorrectData_ShouldReturnCorrectResult()
        {
            await PopulateDataAsync();
            var languageStore = GetSubject();
            
            var languages = languageStore.GetLanguages();
            languages.Should().BeEquivalentTo(new object[]
            {
                new
                {
                    Id = 1, 
                    Code = "en", 
                    Name = "English",
                    IsDefault = true
                },
                new
                {
                    Id = 2, 
                    Code = "bg", 
                    Name = "Bulgarian"
                }
            });
        }
        
        [Fact]
        public void GetLanguages_OnNoData_ShouldReturnEmptyResult()
        {
            var languageStore = GetSubject();
            
            var languages = languageStore.GetLanguages();
            languages.Count().Should().Be(0);
        }
        
        [Fact]
        public async Task GetLanguagesAsync_OnCorrectData_ShouldReturnCorrectResult()
        {
            await PopulateDataAsync();
            var languageStore = GetSubject();
            
            var languages = await languageStore.GetLanguagesAsync();
            languages.Should().BeEquivalentTo(new object[]
            {
                new
                {
                    Id = 1, 
                    Code = "en", 
                    Name = "English",
                    IsDefault = true
                },
                new
                {
                    Id = 2, 
                    Code = "bg", 
                    Name = "Bulgarian"
                }
            });
        }

        [Fact]
        public async Task GetLanguagesAsync_OnNoData_ShouldReturnEmptyResult()
        {
            var languageStore = GetSubject();
            
            var languages = await languageStore.GetLanguagesAsync();
            languages.Count().Should().Be(0);
        }
        
        [Fact]
        public async Task GetLanguageTranslationDictionary_OnCorrectData_ShouldReturnCorrectResult()
        {
            await PopulateDataAsync();
            var languageStore = GetSubject();

            var dictionary = languageStore.GetLanguageTranslationDictionary(1);
            dictionary.Should().BeEquivalentTo(new Dictionary<string, string>
            {
                { "NAME", "Name" },
                { "DOG", "Dog" }
            });
        }
        
        [Fact]
        public void GetLanguageTranslationDictionary_OnNoData_ShouldReturnEmptyResult()
        {
            var languageStore = GetSubject();

            var dictionary = languageStore.GetLanguageTranslationDictionary(1);
            dictionary.Count().Should().Be(0);
        }

        [Fact]
        public async Task GetTranslationsKeys_OnCorrectData_ShouldReturnCorrectResult()
        {
            await PopulateDataAsync();
            var languageStore = GetSubject();

            var keys = languageStore.GetTranslationsKeys();
            keys.Should().BeEquivalentTo(new List<string> { "NAME", "DOG" });
        }
        
        [Fact]
        public void GetTranslationsKeys_OnNoData_ShouldReturnEmptyResult()
        {
            var languageStore = GetSubject();

            var keys = languageStore.GetTranslationsKeys();
            keys.Count().Should().Be(0);
        }
        
        private ILanguageStore GetSubject()
        {
            return new LanguageStore(this.localizationContext, Mock.Of<ILogger<LanguageStore>>());
        }

        private async Task PopulateDataAsync()
        {
            this.localizationContext.Languages.Add(new Language
            {
                Id = 1, 
                Code = "en", 
                Name = "English",
                IsDefault = true
            });
            
            this.localizationContext.Languages.Add(new Language
            {
                Id = 2, 
                Code = "bg", 
                Name = "Bulgarian"
            });

            this.localizationContext.Keys.Add(new TranslationKey
            {
                Id = 1,
                Key = "NAME",
                Translations = new List<TranslationValue>
                {
                    new ()
                    {
                        LanguageId = 1,
                        Value = "Name",
                        NormalizedValue = "NAME"
                    },
                    new ()
                    {
                        LanguageId = 2,
                        Value = "Ime",
                        NormalizedValue = "IME"
                    },
                }
            });
            
            this.localizationContext.Keys.Add(new TranslationKey
            {
                Id = 2,
                Key = "DOG",
                Translations = new List<TranslationValue>
                {
                    new ()
                    {
                        LanguageId = 1,
                        Value = "Dog",
                        NormalizedValue = "DOG"
                    },
                    new ()
                    {
                        LanguageId = 2,
                        Value = "Kuche",
                        NormalizedValue = "KUCHE"
                    },
                }
            });

            await this.localizationContext.SaveChangesAsync();
        }
    }
}