using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Tests.Application.Fakes;
using FluentAssertions;
using Xunit;

namespace Emeraude.Tests.Application.Tests;

public class EmPageSchemaTests
{
    private IEnumerable<Assembly> TargetAssemblies => new List<Assembly>
    {
        this.GetType().Assembly,
    };

    [Fact]
    public async Task BuildDescription_ShouldBuildCorrectDescription_OnSimpleEmPageSchema()
    {
        var schema = new FakeSimpleEmPageSchema();
        var settings = await schema.SetupAsync();
        var schemaDescription = settings.BuildDescription(this.TargetAssemblies);

        schemaDescription.Title.Should().Be(settings.Title);
        schemaDescription.Route.Should().Be(settings.Route);
        schemaDescription.Description.Should().Be(settings.Description);
        schemaDescription.IndexView.IsActive.Should().Be(true);
        schemaDescription.IndexView.OrderProperties.Should().HaveCount(0);
        schemaDescription.IndexView.PageActions.Should().HaveCount(1);
        schemaDescription.IndexView.ViewItems
            .Should()
            .BeEquivalentTo(settings.IndexViewConfigurationBuilder.ViewItems);

        schemaDescription.DetailsView.IsActive.Should().Be(true);
        schemaDescription.DetailsView.PageActions.Should().HaveCount(0);
        schemaDescription.DetailsView.Features.Should().HaveCount(0);
        schemaDescription.DetailsView.ViewItems
            .Should()
            .BeEquivalentTo(settings.DetailsViewConfigurationBuilder.ViewItems);
        
        schemaDescription.FormView.IsActive.Should().Be(false);
        schemaDescription.FormView.PageActions.Should().HaveCount(0);
        schemaDescription.FormView.ViewItems.Should().HaveCount(0);
        schemaDescription.FormView.IsCreateFormActive.Should().Be(false);
        schemaDescription.FormView.IsEditFormActive.Should().Be(false);

        Assert.Null(schemaDescription.IndexView.CustomViewComponent);
    }
}