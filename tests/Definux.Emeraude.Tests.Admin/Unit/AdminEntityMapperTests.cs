using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.Mapping;
using Definux.Emeraude.Admin.UI.Utilities;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Tests.Admin.Fakes;
using Definux.Utilities.Objects;
using FluentAssertions;
using Xunit;

namespace Definux.Emeraude.Tests.Admin.Unit
{
    public class AdminEntityMapperTests
    {
        [Fact]
        public void MapToTableViewModel_EnterNoItems_ShouldReturnCorrectHeader()
        {
            // Arrange
            var entityMapper = this.GetSubject();
            var items = new PaginatedList<SampleEntityViewModelFake>
            {
                Items = new List<SampleEntityViewModelFake>()
            };

            var actions = new TableRowActionViewModel[] { };
            
            // Act
            var tableViewModel = entityMapper.MapToTableViewModel(items, actions);

            // Assert
            tableViewModel
                .Header
                .Cells
                .Select(x => x.Name)
                .ToList()
                .Should()
                .BeEquivalentTo(new List<string>
                {
                    "String Property",
                    "Integer Property",
                    "Double Property",
                    "Enum Property"
                });
        }

        [Fact]
        public void MapToTableViewModel_EnterValidInput_ShouldExecuteCorrectMapping()
        {
            // Arrange
            var entityMapper = this.GetSubject();
            var items = this.GetSampleItems();
            var actions = this.GetSampleActions();
            
            // Act
            var tableViewModel = entityMapper.MapToTableViewModel(items, actions);
            
            // Assert
            for (int i = 0; i < items.ItemsCount; i++)
            {
                tableViewModel
                    .Rows
                    .ElementAt(i)
                    .Actions
                    .Select(x => new
                    {
                        x.Title,
                        x.Icon,
                        x.Method,
                        x.HasConfirmation,
                        x.ConfirmationTitle,
                        x.ConfirmationMessage
                    })
                    .ToList()
                    .Should()
                    .BeEquivalentTo(actions.Select(x => new
                    {
                        x.Title,
                        x.Icon,
                        x.Method,
                        x.HasConfirmation,
                        x.ConfirmationTitle,
                        x.ConfirmationMessage
                    }));

                tableViewModel
                    .Rows
                    .ElementAt(i)
                    .Actions
                    .Select(x => x.Url)
                    .ToList()
                    .Should()
                    .BeEquivalentTo(new List<string>
                    {
                        $"/test-get/{items.Items.ElementAt(i).Id}",
                        $"/test-post/{items.Items.ElementAt(i).IntegerProperty}",
                    });

                tableViewModel
                    .Rows
                    .ElementAt(i)
                    .Cells
                    .Select(x => x.TableElement.DataSource)
                    .ToList()
                    .Should()
                    .BeEquivalentTo(new List<object>
                    {
                        items.Items.ElementAt(i).StringProperty,
                        items.Items.ElementAt(i).IntegerProperty,
                        items.Items.ElementAt(i).DoubleProperty,
                        items.Items.ElementAt(i).EnumProperty,
                    });
            }
        }

        private PaginatedList<SampleEntityViewModelFake> GetSampleItems()
        {
            return new PaginatedList<SampleEntityViewModelFake>
            {
                Items = new List<SampleEntityViewModelFake>
                {
                    new SampleEntityViewModelFake
                    {
                        Id = new Guid("C80B3915-75EF-4235-B0C7-6A48BAC2CFBD"),
                        StringProperty = "Fake Item 1",
                        IntegerProperty = 10,
                        DoubleProperty = 15.14,
                        EnumProperty = DayOfWeek.Monday
                    },
                    new SampleEntityViewModelFake
                    {
                        Id = new Guid("6B562A6C-20DC-41A8-B587-9079A65BE242"),
                        StringProperty = "Fake Item 2",
                        IntegerProperty = 20,
                        DoubleProperty = 27.13,
                        EnumProperty = DayOfWeek.Friday
                    }
                }
            };
        }

        private TableRowActionViewModel[] GetSampleActions()
        {
            return new TableRowActionViewModel[]
            {
                new TableRowActionViewModel
                {
                    Title = "Get Action",
                    Icon = MaterialDesignIcons.Play,
                    Method = TableRowActionMethod.Get,
                    UrlStringFormat = "/test-get/{0}",
                    RawParameters = new List<string> { "[Id]" }
                },
                new TableRowActionViewModel
                {
                    Title = "Post Action",
                    Icon = MaterialDesignIcons.Pause,
                    Method = TableRowActionMethod.Post,
                    UrlStringFormat = "/test-post/{0}",
                    RawParameters = new List<string> { "[IntegerProperty]" },
                    HasConfirmation = true,
                    ConfirmationTitle = "Confirmation Title",
                    ConfirmationMessage = "Confirmation Title"
                }
            };
        }
        
        private IAdminEntityMapper GetSubject()
        {
            return new AdminEntityMapper();
        }
    }
}