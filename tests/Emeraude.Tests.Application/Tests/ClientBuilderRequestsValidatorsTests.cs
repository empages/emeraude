using System.Collections.Generic;
using System.Threading.Tasks;
using Emeraude.Application.ClientBuilder.Requests.Commands.CreateContentKeyWithContent;
using Emeraude.Application.ClientBuilder.Requests.Commands.CreateKeyWithValues;
using Emeraude.Application.ClientBuilder.Requests.Commands.CreateLanguage;
using Emeraude.Application.ClientBuilder.Requests.Commands.EditContentKeyWithContent;
using Emeraude.Application.ClientBuilder.Requests.Commands.EditLanguage;
using Emeraude.Application.ClientBuilder.Requests.Commands.EditTranslationKeyWithValues;
using Emeraude.Infrastructure.Localization.Persistence;
using Emeraude.Infrastructure.Localization.Persistence.Entities;
using Emeraude.Tests.Base;
using Xunit;

namespace Emeraude.Tests.Application.Tests;

public class ClientBuilderRequestsValidatorsTests
{
    private readonly ILocalizationContext localizationContext;
        
    public ClientBuilderRequestsValidatorsTests()
    {
        this.localizationContext = new TestsDatabaseContextBuilder<LocalizationContext>().Build();
    }

    [InlineData("en", "English", "English", false)]
    [InlineData("fr", "French", "French", true)]
    [InlineData("", "French", "French", false)]
    [InlineData(null, "French", "French", false)]
    [InlineData("french", "French", "French", false)]
    [InlineData("fr", "", "French", false)]
    [InlineData("fr", "French", "", false)]
    [Theory]
    public async Task Validate_CreateLanguageCommand_OnVariousData(string code, string name, string nativeName, bool isValid)
    {
        await this.PopulateDataAsync();
        var validator = new CreateLanguageCommandValidator(this.localizationContext);
        var model = new CreateLanguageCommand
        {
            Code = code,
            Name = name,
            NativeName = nativeName
        };

        var validationResult = await validator.ValidateAsync(model);
        Assert.Equal(isValid, validationResult.IsValid);
    }
    
    [InlineData(1, "en", "English", "English", true)]
    [InlineData(1, "fr", "French", "French", true)]
    [InlineData(1, "", "French", "French", false)]
    [InlineData(1, null, "French", "French", false)]
    [InlineData(1, "french", "French", "French", false)]
    [InlineData(1, "fr", "", "French", false)]
    [InlineData(1, "fr", "French", "", false)]
    [Theory]
    public async Task Validate_EditLanguageCommand_OnVariousData(int id, string code, string name, string nativeName, bool isValid)
    {
        await this.PopulateDataAsync();
        var validator = new EditLanguageCommandValidator(this.localizationContext);
        var model = new EditLanguageCommand
        {
            Id = id,
            Code = code,
            Name = name,
            NativeName = nativeName
        };

        var validationResult = await validator.ValidateAsync(model);
        Assert.Equal(isValid, validationResult.IsValid);
    }

    [InlineData("", false)]
    [InlineData(null, false)]
    [InlineData("DOG_STATIC", false)]
    [InlineData("DOG_STATIC_2", true)]
    [Theory]
    public async Task Validate_CreateContentKeyWithContentCommand_OnVariousData(string key, bool isValid)
    {
        await this.PopulateDataAsync();
        var validator = new CreateContentKeyWithContentCommandValidator(this.localizationContext);
        var model = new CreateContentKeyWithContentCommand
        {
            Key = key,
        };

        var validationResult = await validator.ValidateAsync(model);
        Assert.Equal(isValid, validationResult.IsValid);
    }
    
    [InlineData(1, "", false)]
    [InlineData(1, null, false)]
    [InlineData(1, "DOG_STATIC", true)]
    [InlineData(1, "DOG_STATIC_2", true)]
    [Theory]
    public async Task Validate_EditContentKeyWithContentCommand_OnVariousData(int id, string key, bool isValid)
    {
        await this.PopulateDataAsync();
        var validator = new EditContentKeyWithContentCommandValidator(this.localizationContext);
        var model = new EditContentKeyWithContentCommand()
        {
            KeyId = id,
            Key = key,
        };

        var validationResult = await validator.ValidateAsync(model);
        Assert.Equal(isValid, validationResult.IsValid);
    }
    
    [InlineData("", false)]
    [InlineData(null, false)]
    [InlineData("DOG", false)]
    [InlineData("DOG_2", true)]
    [Theory]
    public async Task Validate_CreateKeyWithValuesCommand_OnVariousData(string key, bool isValid)
    {
        await this.PopulateDataAsync();
        var validator = new CreateKeyWithValuesCommandValidator(this.localizationContext);
        var model = new CreateKeyWithValuesCommand
        {
            Key = key,
        };

        var validationResult = await validator.ValidateAsync(model);
        Assert.Equal(isValid, validationResult.IsValid);
    }
    
    [InlineData(2, "", false)]
    [InlineData(2, null, false)]
    [InlineData(2, "DOG", true)]
    [InlineData(2, "DOG_2", true)]
    [Theory]
    public async Task Validate_EditTranslationKeyWithValuesCommand_OnVariousData(int id, string key, bool isValid)
    {
        await this.PopulateDataAsync();
        var validator = new EditTranslationKeyWithValuesCommandValidator(this.localizationContext);
        var model = new EditTranslationKeyWithValuesCommand
        {
            Id = id,
            Key = key,
        };

        var validationResult = await validator.ValidateAsync(model);
        Assert.Equal(isValid, validationResult.IsValid);
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
            }
        });
        
        this.localizationContext.ContentKeys.Add(new ContentKey
        {
            Id = 1,
            Key = "DOG_STATIC",
            StaticContentList = new List<StaticContent>
            {
                new ()
                {
                    LanguageId = 1,
                    Content = "Dog static",
                    NormalizedContent = "DOG STATIC"
                },
            }
        });

        await this.localizationContext.SaveChangesAsync();
    }
}