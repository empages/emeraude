using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Models;
using Definux.Emeraude.Tests.Base;
using Definux.Emeraude.Tests.Project.Application.Models;
using FluentAssertions;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using Xunit;

namespace Definux.Emeraude.Tests.Core.Integration
{
    public class JsonConvertorsTests : IntegrationTest
    {
        private const string DefaultMediaType = "application/json";
        
        public JsonConvertorsTests(EmeraudeWebApplicationFactory factory)
            : base(factory)
        {
        }
        
        [InlineData("date-model", "\"1991-07-07\"", "1991-07-07")]
        [InlineData("date-model", "\"1991-17-07\"", "0001-01-01")]
        [InlineData("date-model", "null", "0001-01-01")]
        [InlineData("date-model-nullable", "\"1991-07-07\"", "1991-07-07")]
        [InlineData("date-model-nullable", "\"1991-17-07\"", "0001-01-01")]
        [InlineData("date-model-nullable", "null", "")]
        [Theory]
        public async Task DateModel_OnPostRequestWithDateModel_ShouldReturnCorrectCorrespondingDateString(string route, string inputDateString, string outputDateString)
        {
            // Arrange
            var httpClient = this.Factory.CreateClient();
            string jsonContent = $"{{\"date\": {inputDateString}}}";
            var postRequest = Base.Utilities.BuildPostRequestMessageWithBody($"/api/json-serializer/{route}", jsonContent);

            // Act
            var response = await httpClient.SendAsync(postRequest);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();

            // Assert
            responseString
                .Should()
                .Be(outputDateString);
        }
    }
}