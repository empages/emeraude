using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace EmPages.Pages.Tests;

public class EmTypeTests
{
    [InlineData(typeof(string), typeof(string), true, true, false, false, TypeGroup.Texts)]
    [InlineData(typeof(char), typeof(char), true, false, false, false, TypeGroup.Texts)]
    [InlineData(typeof(IEnumerable<string>), typeof(string), false, true, true, false, TypeGroup.Arrays)]
    [InlineData(typeof(int), typeof(int), true, false, false, false, TypeGroup.Numbers)]
    [InlineData(typeof(int?), typeof(int), true, true, false, false, TypeGroup.Numbers)]
    [InlineData(typeof(IEnumerable<int>), typeof(int), false, true, true, false, TypeGroup.Arrays)]
    [InlineData(typeof(bool), typeof(bool), true, false, false, false, TypeGroup.Booleans)]
    [InlineData(typeof(bool?), typeof(bool), true, true, false, false, TypeGroup.Booleans)]
    [InlineData(typeof(IEnumerable<bool>), typeof(bool), false, true, true, false, TypeGroup.Arrays)]
    [InlineData(typeof(DateTime), typeof(DateTime), true, false, false, false, TypeGroup.DateTimes)]
    [InlineData(typeof(DateTime?), typeof(DateTime), true, true, false, false, TypeGroup.DateTimes)]
    [InlineData(typeof(IEnumerable<DateTime>), typeof(DateTime), false, true, true, false, TypeGroup.Arrays)]
    [InlineData(typeof(DayOfWeek), typeof(DayOfWeek), false, false, false, true, TypeGroup.Enumerations)]
    [InlineData(typeof(DayOfWeek?), typeof(DayOfWeek), false, true, false, true, TypeGroup.Enumerations)]
    [InlineData(typeof(IEnumerable<DayOfWeek>), typeof(DayOfWeek), false, true, true, true, TypeGroup.Arrays)]
    [Theory]
    public void New_OnCreation_ShouldCreateCorrectWrappedType(
        Type inputType,
        Type expectedUnderlyingType,
        bool isPrimitive,
        bool isNullable,
        bool isEnumerable,
        bool isEnum,
        TypeGroup group)
    {
        var type = new EmType(inputType);
        Assert.Equal(type.SourceType, expectedUnderlyingType);
        Assert.Equal(type.IsPrimitive, isPrimitive);
        Assert.Equal(type.IsNullable, isNullable);
        Assert.Equal(type.IsEnumerable, isEnumerable);
        Assert.Equal(type.IsEnum, isEnum);
    }

    [InlineData(typeof(string[]))]
    [InlineData(typeof(int[]))]
    [InlineData(typeof(DateTime[]))]
    [InlineData(typeof(DayOfWeek[]))]
    [InlineData(typeof(IQueryable<DayOfWeek>))]
    [InlineData(typeof(StringBuilder))]
    [Theory]
    public void New_OnCreationOfInvalidType_ShouldThrows(Type type)
    {
        Assert.Throws<ArgumentException>(() => new EmType(type));
    }
}