using Definux.Emeraude.Configuration.Exceptions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Tests.Sdk.Fakes;
using FluentAssertions;
using Xunit;

namespace Definux.Emeraude.Tests.Sdk.Unit
{
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
                    .GetOptions<EmFakeOptions>());

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
}