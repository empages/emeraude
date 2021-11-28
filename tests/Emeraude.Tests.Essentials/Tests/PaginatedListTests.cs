using System;
using Emeraude.Essentials.Models;
using Xunit;

namespace Emeraude.Tests.Essentials.Tests
{
    public class PaginatedListTests
    {
        [Fact]
        public void PagesCount_CorrectSetup_ExpectedResult()
        {
            var paginatedList = new PaginatedList<int>
            {
                AllItemsCount = 32,
                PageSize = 10
            };
            
            Assert.Equal(4, paginatedList.PagesCount);
        }

        [Fact]
        public void ValidateList_InvalidData_ThrowException()
        {
            var paginatedList = new PaginatedList<int>
            {
                PageSize = 5,
                Items = new [] { 1, 2, 3, 5, 6, 7 }
            };

            Assert.Throws<ArgumentException>(() =>
            {
                paginatedList.ValidateList();
            });
        }
    }
}