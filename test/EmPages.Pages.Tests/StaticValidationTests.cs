using EmPages.Pages.StaticValidation;
using FluentAssertions;
using Xunit;

namespace EmPages.Pages.Tests;

public class StaticValidationTests
{
    [Fact]
    public void ValidateModelType_OnValidModel_ShouldDoNothing()
    {
        ModelValidator.ValidateModelType(typeof(TestPageModel));
    }
    
    [Fact]
    public void ValidateModelType_OnRandomClassModel_ShouldThrows()
    {
        var exception = Assert.Throws<EmSetupException>(() => ModelValidator.ValidateModelType(typeof(RandomPageModel)));
        exception
            .Message
            .Should()
            .Contain(nameof(IEmPageModel));
    }
    
    [Fact]
    public void ValidateModelType_OnInvalidModel_ShouldThrows()
    {
        var exception = Assert.Throws<EmSetupException>(() => ModelValidator.ValidateModelType(typeof(WrongTestPageModel)));
        exception
            .Message
            .Should()
            .Contain(nameof(WrongTestPageModel.StringBuilder));
    }
}