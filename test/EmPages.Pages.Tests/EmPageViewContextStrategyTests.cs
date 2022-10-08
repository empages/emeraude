using System.Collections.Generic;
using System.Linq;
using EmPages.Pages.Components.Renderers;
using FluentAssertions;
using Xunit;

namespace EmPages.Pages.Tests;

public class EmPageViewContextStrategyTests
{
    [Fact]
    public void Configure_OnNewViewItemConfiguration_ShouldAddTheItemInto()
    {
        var viewContext = this.GetSubject<TestPageModel>();
        viewContext
            .Configure(x => x.Id, item =>
            {
                item.Label = "Identifier";
                item.Order = 1;
            });

        viewContext
            .ViewItems
            .Should()
            .HaveCount(1);

        viewContext
            .ViewItems
            .First()
            .Should()
            .BeEquivalentTo(new
            {
                Label = "Identifier",
                Order = 1
            });
    }
    
    [Fact]
    public void Configure_OnExistingViewItemConfiguration_ShouldReplaceTheItem()
    {
        var viewContext = this.GetSubject<TestPageModel>();
        viewContext
            .Configure(x => x.Id, item =>
            {
                item.Label = "Identifier";
                item.Order = 1;
            });

        viewContext
            .Configure(x => x.Id, item =>
            {
                item.Label = "Id";
                item.Order = 0;
            });

        viewContext
            .ViewItems
            .Should()
            .HaveCount(1);

        viewContext
            .ViewItems
            .First()
            .Should()
            .BeEquivalentTo(new
            {
                Label = "Id",
                Order = 0
            });
    }

    [Fact]
    public void Exclude_OnExistingViewItem_ShouldRemoveTheItem()
    {
        var viewContext = this.GetSubject<TestPageModel>();
        viewContext
            .Configure(x => x.Id, item =>
            {
                item.Label = "Identifier";
                item.Order = 1;
            });

        viewContext.Exclude(x => x.Id);

        viewContext
            .ViewItems
            .Should()
            .HaveCount(0);
    }

    [Fact]
    public void Exclude_OnNonExistingViewItem_ShouldDoNothing()
    {
        var viewContext = this.GetSubject<TestPageModel>();
        viewContext.Exclude(x => x.Id);

        viewContext
            .ViewItems
            .Should()
            .HaveCount(0);
    }

    [Fact]
    public void ConfigureAll_OnNotSpecifiedOptions_ShouldConfigureValidViewItems()
    {
        var viewContext = this.GetSubject<TestPageModel>();
        viewContext.ConfigureAll(new EmOptions());
        
        viewContext
            .ViewItems
            .Should()
            .HaveCount(5);

        viewContext
            .ViewItems
            .Select(x => x.Component)
            .Should()
            .AllBeOfType<TextRenderer>();

        viewContext
            .ViewItems
            .Select(x => x.Order)
            .Should()
            .BeEquivalentTo(new List<int> { 0, 1, 2, 3, 4 });

        viewContext
            .ViewItems
            .Select(x => x.Label)
            .Should()
            .BeEquivalentTo("Id", "First Name", "Last Name", "Age", "Active");
    }
    
    private FakeViewContext<TModel> GetSubject<TModel>()
        where TModel : class, IEmPageModel, new()
    {
        return new FakeViewContext<TModel>();
    }
}