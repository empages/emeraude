using Emeraude.Application.Models;
using Emeraude.Tests.Application.Fakes;
using Emeraude.Tests.Base;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Emeraude.Tests.Application.Tests;

public class JsonConvertorsTests
{
    [Fact]
    public void DeserializeDateModel_OnValidString_ShouldReturnCorrectDateModel()
    {
        string jsonContent = "{\"date\": \"1991-07-07\"}";

        var model = JsonConvert.DeserializeObject<FakeDateModelObject>(jsonContent, TestsDefaults.JsonSerializerSettings);

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
        string jsonContent = "{\"date\": \"1991-17-07\"}";

        var model = JsonConvert.DeserializeObject<FakeDateModelObject>(jsonContent, TestsDefaults.JsonSerializerSettings);

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
        string jsonContent = "{\"date\": null}";

        var model = JsonConvert.DeserializeObject<FakeDateModelObject>(jsonContent, TestsDefaults.JsonSerializerSettings);

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
        string jsonContent = "{\"date\": \"1991-07-07\"}";

        var model = JsonConvert.DeserializeObject<FakeDateModelNullableObject>(jsonContent, TestsDefaults.JsonSerializerSettings);

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
        string jsonContent = "{\"date\": \"1991-17-07\"}";

        var model = JsonConvert.DeserializeObject<FakeDateModelNullableObject>(jsonContent, TestsDefaults.JsonSerializerSettings);

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
        string jsonContent = "{\"date\": null}";

        var model = JsonConvert.DeserializeObject<FakeDateModelNullableObject>(jsonContent, TestsDefaults.JsonSerializerSettings);

        model
            .Date
            .Should()
            .Be(null);
    }
}