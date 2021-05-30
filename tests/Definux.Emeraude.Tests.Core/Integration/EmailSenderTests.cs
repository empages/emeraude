using System.Threading.Tasks;
using Definux.Emeraude.Application.Emails;
using Definux.Emeraude.Tests.Base;
using Definux.Emeraude.Tests.Project.Application.Emails;
using Xunit;

namespace Definux.Emeraude.Tests.Core.Integration
{
    public class EmailSenderTests
    {
        private readonly TestServiceProvider testServiceProvider;

        public EmailSenderTests()
        {
            this.testServiceProvider = TestServiceProvider.GetInstance();
        }
        
        [Fact]
        public async Task SendEmailAsync_CustomSenderRegistered_ShouldReturnSuccess()
        {
            // Arrange
            var renderer = this.testServiceProvider.GetService<IEmailSender>();           

            // Act
            var result = await renderer.SendEmailAsync("SampleEmail", new SampleEmailModel());

            // Assert
            Assert.True(result.Success);
        }
    }
}