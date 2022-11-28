using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace EmPages.Pages.Tests;

public class EmPageValidatorsTests
{
    [InlineData(typeof(string), true)]
    [InlineData(typeof(char), true)]
    [InlineData(typeof(bool), true)]
    [InlineData(typeof(byte), true)]
    [InlineData(typeof(sbyte), true)]
    [InlineData(typeof(short), true)]
    [InlineData(typeof(ushort), true)]
    [InlineData(typeof(int), true)]
    [InlineData(typeof(uint), true)]
    [InlineData(typeof(long), true)]
    [InlineData(typeof(ulong), true)]
    [InlineData(typeof(double), true)]
    [InlineData(typeof(decimal), true)]
    [InlineData(typeof(DateTime), true)]
    [InlineData(typeof(DateOnly), true)]
    [InlineData(typeof(TimeOnly), true)]
    [InlineData(typeof(DayOfWeek), true)]
    [InlineData(typeof(char?), true)]
    [InlineData(typeof(bool?), true)]
    [InlineData(typeof(byte?), true)]
    [InlineData(typeof(sbyte?), true)]
    [InlineData(typeof(short?), true)]
    [InlineData(typeof(ushort?), true)]
    [InlineData(typeof(int?), true)]
    [InlineData(typeof(uint?), true)]
    [InlineData(typeof(long?), true)]
    [InlineData(typeof(ulong?), true)]
    [InlineData(typeof(double?), true)]
    [InlineData(typeof(decimal?), true)]
    [InlineData(typeof(DateTime?), true)]
    [InlineData(typeof(DateOnly?), true)]
    [InlineData(typeof(TimeOnly?), true)]
    [InlineData(typeof(DayOfWeek?), true)]
    [InlineData(typeof(nint), false)]
    [InlineData(typeof(nint?), false)]
    [InlineData(typeof(IEnumerable<string>), true)]
    [InlineData(typeof(IEnumerable<char>), true)]
    [InlineData(typeof(IEnumerable<bool>), true)]
    [InlineData(typeof(IEnumerable<byte>), true)]
    [InlineData(typeof(IEnumerable<sbyte>), true)]
    [InlineData(typeof(IEnumerable<short>), true)]
    [InlineData(typeof(IEnumerable<ushort>), true)]
    [InlineData(typeof(IEnumerable<int>), true)]
    [InlineData(typeof(IEnumerable<uint>), true)]
    [InlineData(typeof(IEnumerable<long>), true)]
    [InlineData(typeof(IEnumerable<ulong>), true)]
    [InlineData(typeof(IEnumerable<double>), true)]
    [InlineData(typeof(IEnumerable<decimal>), true)]
    [InlineData(typeof(IEnumerable<DateTime>), true)]
    [InlineData(typeof(IEnumerable<DateOnly>), true)]
    [InlineData(typeof(IEnumerable<TimeOnly>), true)]
    [InlineData(typeof(IEnumerable<DayOfWeek>), true)]
    [InlineData(typeof(IEnumerable<char?>), false)]
    [InlineData(typeof(IEnumerable<bool?>), false)]
    [InlineData(typeof(IEnumerable<byte?>), false)]
    [InlineData(typeof(IEnumerable<sbyte?>), false)]
    [InlineData(typeof(IEnumerable<short?>), false)]
    [InlineData(typeof(IEnumerable<ushort?>), false)]
    [InlineData(typeof(IEnumerable<int?>), false)]
    [InlineData(typeof(IEnumerable<uint?>), false)]
    [InlineData(typeof(IEnumerable<long?>), false)]
    [InlineData(typeof(IEnumerable<ulong?>), false)]
    [InlineData(typeof(IEnumerable<double?>), false)]
    [InlineData(typeof(IEnumerable<decimal?>), false)]
    [InlineData(typeof(IEnumerable<DateTime?>), false)]
    [InlineData(typeof(IEnumerable<DateOnly?>), false)]
    [InlineData(typeof(IEnumerable<TimeOnly?>), false)]
    [InlineData(typeof(IEnumerable<DayOfWeek?>), false)]
    [InlineData(typeof(string[]), false)]
    [InlineData(typeof(int[]), false)]
    [InlineData(typeof(DayOfWeek[]), false)]
    [InlineData(typeof(DateTime[]), false)]
    [InlineData(typeof(Version), false)]
    [InlineData(typeof(IEnumerable<Version>), false)]
    [InlineData(typeof(object), false)]
    [InlineData(typeof(IDictionary<string, string>), false)]
    [InlineData(typeof(List<string>), false)]
    [InlineData(typeof(HashSet<string>), false)]
    [InlineData(typeof(IQueryable<string>), false)]
    [InlineData(typeof(ICollection<string>), false)]
    [Theory]
    public void IsTypeSupported_OnProvidedType_ShouldReturnsCorrectBoolean(Type type, bool isSupported)
    {
        EmPageValidators.IsTypeSupported(type).Should().Be(isSupported);
    }
    
    [Fact]
    public void ValidateModelType_OnValidModel_ShouldDoNothing()
    {
        EmPageValidators.ValidateModelType(typeof(TestPageModel));
    }
    
    [Fact]
    public void ValidateModelType_OnRandomClassModel_ShouldThrows()
    {
        var exception = Assert.Throws<EmSetupException>(() => EmPageValidators.ValidateModelType(typeof(RandomPageModel)));
        exception
            .Message
            .Should()
            .Contain(nameof(IEmPageModel));
    }
    
    [Fact]
    public void ValidateModelType_OnInvalidModel_ShouldThrows()
    {
        var exception = Assert.Throws<EmSetupException>(() => EmPageValidators.ValidateModelType(typeof(WrongTestPageModel)));
        exception
            .Message
            .Should()
            .Contain(nameof(WrongTestPageModel.StringBuilder));
    }
}