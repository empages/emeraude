using Definux.Emeraude.Application.Models;
using Definux.Emeraude.Tests.Base;
using Definux.Emeraude.Tests.Core.Fakes;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Definux.Emeraude.Tests.Core.Unit
{
    public class JsonConvertorsTests
    {
        [Fact]
        public void DeserializeDateModel_OnValidString_ShouldReturnCorrectDateModel()
        {
            // Arrange
            string jsonContent = "{\"date\": \"1991-07-07\"}";
            
            // Act
            var model = JsonConvert.DeserializeObject<FakeDateModelObject>(jsonContent, Defaults.JsonSerializerSettings);
            
            // Assert
            model
                .Date
                .Should()
                .BeEquivalentTo(new DateModel
                {
                    Year = 1991,
                    Month = 7,
                    Day = 7
                });
        }
        
        [Fact]
        public void DeserializeDateModel_OnInvalidString_ShouldReturnDefaultDateModel()
        {
            // Arrange
            string jsonContent = "{\"date\": \"1991-17-07\"}";
            
            // Act
            var model = JsonConvert.DeserializeObject<FakeDateModelObject>(jsonContent, Defaults.JsonSerializerSettings);
            
            // Assert
            model
                .Date
                .Should()
                .BeEquivalentTo(new DateModel
                {
                    Year = 1,
                    Month = 1,
                    Day = 1,
                });
        }
        
        [Fact]
        public void DeserializeDateModel_OnNull_ShouldReturnDefaultDataModel()
        {
            // Arrange
            string jsonContent = "{\"date\": null}";
            
            // Act
            var model = JsonConvert.DeserializeObject<FakeDateModelObject>(jsonContent, Defaults.JsonSerializerSettings);
            
            // Assert
            model
                .Date
                .Should()
                .BeEquivalentTo(new DateModel
                {
                    Year = 1,
                    Month = 1,
                    Day = 1,
                });
        }
        
        [Fact]
        public void DeserializeNullableDateModel_OnValidString_ShouldReturnCorrectNullableDateModel()
        {
            // Arrange
            string jsonContent = "{\"date\": \"1991-07-07\"}";
            
            // Act
            var model = JsonConvert.DeserializeObject<FakeDateModelNullableObject>(jsonContent, Defaults.JsonSerializerSettings);
            
            // Assert
            model
                .Date
                .Should()
                .BeEquivalentTo(new DateModel
                {
                    Year = 1991,
                    Month = 7,
                    Day = 7
                });
        }
        
        [Fact]
        public void DeserializeNullableDateModel_OnInvalidString_ShouldReturnDefaultNullableDateModel()
        {
            // Arrange
            string jsonContent = "{\"date\": \"1991-17-07\"}";
            
            // Act
            var model = JsonConvert.DeserializeObject<FakeDateModelNullableObject>(jsonContent, Defaults.JsonSerializerSettings);
            
            // Assert
            model
                .Date
                .Should()
                .BeEquivalentTo(new DateModel
                {
                    Year = 1,
                    Month = 1,
                    Day = 1,
                });
        }
        
        [Fact]
        public void DeserializeNullableDateModel_OnNull_ShouldReturnNull()
        {
            // Arrange
            string jsonContent = "{\"date\": null}";
            
            // Act
            var model = JsonConvert.DeserializeObject<FakeDateModelNullableObject>(jsonContent, Defaults.JsonSerializerSettings);
            
            // Assert
            model
                .Date
                .Should()
                .Be(null);
        }
    }
}