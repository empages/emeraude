using Emeraude.Essentials.Validation;
using Emeraude.Tests.Essentials.Fakes;
using Xunit;

namespace Emeraude.Tests.Essentials.Tests
{
    public class ValidationTests
    {
        [InlineData("This is cool text 123", true, "")]
        [InlineData("123 32", false, FakeLetterHandler.ErrorMessage)]
        [InlineData("Random text", false, FakeDigitHandler.ErrorMessage)]
        [InlineData("!@#$", false, FakeLetterHandler.ErrorMessage)]
        [Theory]
        public void HandleValidation_ValidWorkflow_SuccessPassing(string text, bool valid, string expectedErrorMessage)
        {
            var startupHandler = new StartupHandler<string>();
            startupHandler
                .SetNext(new FakeLetterHandler())
                .SetNext(new FakeDigitHandler());

            var result = startupHandler.Handle(text, out var errorMessage);

            Assert.Equal(valid, result == text);
            Assert.Equal(expectedErrorMessage, errorMessage);
        }
    }
}