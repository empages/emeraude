using System.Threading.Tasks;
using Definux.Emeraude.Admin.Requests.GetAll;
using Definux.Emeraude.Tests.Admin.Integration.Abstractions;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Models;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Domain;
using MediatR;
using Xunit;

namespace Definux.Emeraude.Tests.Admin.Integration.Tests
{
    public class GetAllQueryTests : AbstractTestConstructor
    {
        [Theory]
        [InlineData(1, null, 3)]
        [InlineData(1, "for you", 1)]
        [InlineData(1, "me", 2)]
        public async Task GetAllQuery_ValidSearchQueryForSimpleEntity_ReturnsCorrectAmountOfData(int page, string searchQuery, int expectedAmountOfData)
        {
            // Arrange
            var mediator = this.GetService<IMediator>();
            var getAllRequest = new GetAllQuery<SimpleEntity, SimpleEntityViewModel>(page, searchQuery);

            // Act
            var queryResult = await mediator.Send(getAllRequest);

            // Assert
            Assert.Equal(expectedAmountOfData, queryResult.ItemsCount);
        }
    }
}