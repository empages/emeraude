using System.Threading.Tasks;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Tests.Base;
using Xunit;

namespace Definux.Emeraude.Tests.Admin.Integration
{
    public class AuthenticationTests : AdminIntegrationTest
    {
        public AuthenticationTests(EmeraudeWebApplicationFactory factrory)
            : base(factrory)
        {
            
        }
        
        [Fact]
        public async Task Login_EnterCorrectCredentialsWithAccessAdministrationPermission_SuccessLogin()
        {
            // Arrange
            await this.AuthenticateAsync(EmIdentityConstants.DefaultEmeraudeAdminEmail, EmIdentityConstants.DefaultEmeraudeAdminPassword);            

            // Act
            var adminDashboardResponse = await this.HttpClient.GetAsync("/admin");
            var adminDashboardHtml = await adminDashboardResponse.Content.ReadAsStringAsync();

            // Assert
            Assert.DoesNotContain("/admin/login", adminDashboardResponse.RequestMessage.RequestUri.ToString());
            Assert.Contains($"{EmIdentityConstants.DefaultEmeraudeAdminName} ({EmIdentityConstants.DefaultEmeraudeAdminEmail})", adminDashboardHtml);
        }
        
        [Fact]
        public async Task Login_EnterCorrectCredentialsWithoutAccessAdministrationPermission_FailedLogin()
        {
            // Arrange
            await this.AuthenticateAsync(EmIdentityConstants.DefaultEmeraudeUserName, EmIdentityConstants.DefaultEmeraudeUserEmail);            

            // Act
            var adminDashboardResponse = await this.HttpClient.GetAsync("/admin");
            var adminDashboardHtml = await adminDashboardResponse.Content.ReadAsStringAsync();
            
            // Assert
            Assert.Contains("/admin/login", adminDashboardResponse.RequestMessage.RequestUri.ToString());
            Assert.DoesNotContain($"{EmIdentityConstants.DefaultEmeraudeAdminName} ({EmIdentityConstants.DefaultEmeraudeAdminEmail})", adminDashboardHtml);
        }
    }
}