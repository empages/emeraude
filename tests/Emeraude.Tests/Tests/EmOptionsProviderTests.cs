using Emeraude.Configuration.Exceptions;
using Emeraude.Configuration.Options;
using Emeraude.Tests.Fakes;
using FluentAssertions;
using Xunit;

namespace Emeraude.Tests.Tests;

public class EmOptionsProviderTests
{
    [Fact]
    public void GetOptions_RegisteredType_ShouldReturnCorrectInstance()
        => this.GetSubject(GetDefaultOptionsSetup())
            .GetOptions<EmMainOptions>()
            .Should()
            .BeEquivalentTo(GetDefaultOptionsSetup().MainOptions);

    [Fact]
    public void GetOptions_UnregisteredType_ShouldThrows()
        => Assert.Throws<EmOptionsNotFoundException>(()
            => this.GetSubject(GetDefaultOptionsSetup())
                .GetOptions<FakeEmOptions>());

    [Fact]
    public void GetOptionValue_ForValidKeyAndTypeString_ShouldReturnCorrectValue()
        => this.GetSubject(GetDefaultOptionsSetup())
            .GetOptionValue<string>("MainOptions:ProjectName")
            .Should()
            .Be("Test");
        
    [Fact]
    public void GetOptionValue_ForValidKeyAndTypeBool_ShouldReturnCorrectValue()
        => this.GetSubject(GetDefaultOptionsSetup())
            .GetOptionValue<bool>("MainOptions:TestMode")
            .Should()
            .Be(true);
        
    private IEmOptionsProvider GetSubject(EmOptionsSetup setup)
        => new EmOptionsProvider(setup);

    private static EmOptionsSetup GetDefaultOptionsSetup()
        => new()
        {
            MainOptions = new EmMainOptions
            {
                ProjectName = "Test",
                TestMode = true,
            }
        };
}