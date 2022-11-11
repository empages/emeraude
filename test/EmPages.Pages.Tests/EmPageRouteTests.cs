using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace EmPages.Pages.Tests;

public class EmPageRouteTests
{
    [InlineData("")]
    [InlineData("/")]
    [InlineData("//")]
    [InlineData("//dogs")]
    [InlineData("/dogs//items")]
    [InlineData("/dogs/{{id}")]
    [InlineData("/dogs$/{id}")]
    [InlineData("/auth")]
    [InlineData("/manage")]
    [InlineData("/settings")]
    [Theory]
    public void Initialization_OnRouteRawTemplate_ShouldThrows(string routeRawTemplate)
    {
        Assert.ThrowsAny<Exception>(() => new EmPageRoute(routeRawTemplate));
    }
    
    [Fact]
    public void Initialization_OnSimpleRoute_PropertiesShouldBeWithCorrectValues()
    {
        var route = new EmPageRoute("/dogs");
        route
            .Template
            .Should()
            .Be("dogs");

        route
            .Segments
            .Should()
            .HaveCount(1);

        route
            .Segments
            .First()
            .Should()
            .BeEquivalentTo(new
            {
                Dynamic = false,
                Value = "dogs"
            });
    }
    
    [Fact]
    public void Initialization_OnComplexRoute_PropertiesShouldBeWithCorrectValues()
    {
        var route = new EmPageRoute("/dogs/{id}/preferences");
        route
            .Template
            .Should()
            .Be("dogs/{id}/preferences");

        route
            .Segments
            .Should()
            .HaveCount(3);

        route
            .Segments
            .ElementAt(0)
            .Should()
            .BeEquivalentTo(new
            {
                Dynamic = false,
                Value = "dogs"
            });
        
        route
            .Segments
            .ElementAt(1)
            .Should()
            .BeEquivalentTo(new
            {
                Dynamic = true,
                Value = "id"
            });
        
        route
            .Segments
            .ElementAt(2)
            .Should()
            .BeEquivalentTo(new
            {
                Dynamic = false,
                Value = "preferences"
            });
    }

    [Fact]
    public void Build_OnLessThanRequiredPassedDynamicArguments_ShouldThrows()
    {
        var route = new EmPageRoute("/dogs/{dogId}/foods/{foodId}");
        Assert.Throws<ArgumentException>(() => route.Build("101"));
    }
    
    [Fact]
    public void Build_OnMoreThanRequiredPassedDynamicArguments_ShouldThrows()
    {
        var route = new EmPageRoute("/dogs/{dogId}/foods/{foodId}");
        Assert.Throws<ArgumentException>(() => route.Build("101", "333", "22"));
    }
    
    [Fact]
    public void Build_OnStandardInvocation_ShouldReturnCorrectRouteValue()
    {
        var route = new EmPageRoute("/dogs/{dogId}/foods/{foodId}");
        var routeValue = route.Build("101", "333");
        routeValue
            .Should()
            .Be("dogs/101/foods/333");
    }
}