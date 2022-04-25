using FluentAssertions;
using Xunit;

namespace Emeraude.Pages.Tests;

public class EmLayoutContextTests
{
    [Fact]
    public void Initialization_OnStandardContextCreation_PropertiesShouldBeWithCorrectValues()
    {
        var context = new EmLayoutContext
        {
            Title = "Dogs",
            Icon = "icon-dog",
            Order = 2,
            Route = "/dogs",
            Permissions = new []{ "AccessAdministration", "DogsManagement" }
        };

        context
            .Should()
            .BeEquivalentTo(new
            {
                Title = "Dogs",
                Icon = "icon-dog",
                Order = 2,
                Route = "/dogs",
                Permissions = new []{ "AccessAdministration", "DogsManagement" }
            });
    }
}