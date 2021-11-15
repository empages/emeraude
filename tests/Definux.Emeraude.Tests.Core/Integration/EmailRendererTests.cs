using System.Threading.Tasks;
using Emeraude.Application.Emails;
using Emeraude.Tests.Base;
using Emeraude.Tests.Project.Application.Emails;
using Xunit;

namespace Definux.Emeraude.Tests.Core.Integration
{
    public class EmailRendererTests
    {
        private readonly TestServiceProvider testServiceProvider;

        public EmailRendererTests()
        {
            this.testServiceProvider = TestServiceProvider.GetInstance();
        }

        [Fact]
        public async Task RenderToStringAsync_CorrectTemplateAndModel_CorrectHtmlBody()
        {
            // Arrange
            var renderer = this.testServiceProvider.GetService<IEmailRenderer>();           

            // Act
            string message = "test-text-123";
            string renderedHtml = await renderer.RenderToStringAsync("SampleEmail", new SampleEmailModel
            {
                Email = "test@test.test",
                Subject = "Test",
                Message = message,
            });

            // Assert
            Assert.Equal($"<p>{message}</p>", renderedHtml.Trim());
        }
    }
}