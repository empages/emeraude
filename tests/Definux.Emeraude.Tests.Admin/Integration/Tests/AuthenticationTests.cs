using System.Threading.Tasks;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Tests.Abstractions;
using Definux.Emeraude.Tests.Admin.Integration.Abstractions;
using Xunit;

namespace Definux.Emeraude.Tests.Admin.Integration.Tests
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
            await AuthenticateAsync(EmIdentityConstants.DefaultEmeraudeAdminEmail, EmIdentityConstants.DefaultEmeraudeAdminPassword);            

            // Act
            var adminDashboardResponse = await HttpClient.GetAsync("/admin");
            var adminDashboarHtml = await adminDashboardResponse.Content.ReadAsStringAsync();

            // Assert
            Assert.DoesNotContain("/admin/login", adminDashboardResponse.RequestMessage.RequestUri.ToString());
            Assert.Contains($"{EmIdentityConstants.DefaultEmeraudeAdminName} ({EmIdentityConstants.DefaultEmeraudeAdminEmail})", adminDashboarHtml);
        }
        
        [Fact]
        public async Task Login_EnterCorrectCredentialsWithoutAccessAdministrationPermission_FailedLogin()
        {
            // Arrange
            await AuthenticateAsync(EmIdentityConstants.DefaultEmeraudeUserName, EmIdentityConstants.DefaultEmeraudeUserEmail);            

            // Act
            var adminDashboardResponse = await HttpClient.GetAsync("/admin");
            var adminDashboardHtml = await adminDashboardResponse.Content.ReadAsStringAsync();
            
            // Assert
            Assert.Contains("/admin/login", adminDashboardResponse.RequestMessage.RequestUri.ToString());
            Assert.DoesNotContain($"{EmIdentityConstants.DefaultEmeraudeAdminName} ({EmIdentityConstants.DefaultEmeraudeAdminEmail})", adminDashboardHtml);
        }
    }
}