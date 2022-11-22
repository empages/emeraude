using System;
using Xunit;

namespace EmPages.Pages.Tests;

public class EmPageTypeConverterTests
{
    [Fact]
    public void ConvertToType_OnPossibleGuids_ShouldConvertInputCorrectly()
    {
        Assert.Equal(
            Guid.Parse("e6aff63c-9bfc-42f2-ab2f-904733a65598"),
            EmPageTypeConverter.ConvertToType<Guid>("e6aff63c-9bfc-42f2-ab2f-904733a65598"));
        
        Assert.Equal(
            Guid.Parse("e6aff63c-9bfc-42f2-ab2f-904733a65598"),
            EmPageTypeConverter.ConvertToType<Guid>("e6aff63c9bfc42f2ab2f904733a65598"));
        
        Assert.Equal(
            Guid.Empty,
            EmPageTypeConverter.ConvertToType<Guid>("e6f63c-9bfc-42f2-ab2f-90473a65598"));

        Assert.Equal(
            Guid.Empty,
            EmPageTypeConverter.ConvertToType<Guid>(null));
        
        Assert.Equal(
            Guid.Empty,
            EmPageTypeConverter.ConvertToType<Guid>(string.Empty));
        
        Assert.Equal(
            Guid.Parse("e6aff63c-9bfc-42f2-ab2f-904733a65598"),
            EmPageTypeConverter.ConvertToType<Guid?>("e6aff63c-9bfc-42f2-ab2f-904733a65598"));
        
        Assert.Equal(
            Guid.Parse("e6aff63c-9bfc-42f2-ab2f-904733a65598"),
            EmPageTypeConverter.ConvertToType<Guid?>("e6aff63c9bfc42f2ab2f904733a65598"));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<Guid?>("e6f63c-9bfc-42f2-ab2f-90473a65598"));

        Assert.Null(EmPageTypeConverter.ConvertToType<Guid?>(null));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<Guid?>(string.Empty));
    }
    
    [Fact]
    public void ConvertToType_OnPossibleStrings_ShouldConvertInputCorrectly()
    {
        Assert.Equal("test", EmPageTypeConverter.ConvertToType<string>("test"));
        
        Assert.Equal(" ", EmPageTypeConverter.ConvertToType<string>(" "));
        
        Assert.Equal(string.Empty, EmPageTypeConverter.ConvertToType<string>(string.Empty));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<string>(null));
    }
    
    [Fact]
    public void ConvertToType_OnPossibleIntegers_ShouldConvertInputCorrectly()
    {
        Assert.Equal(15, EmPageTypeConverter.ConvertToType<short>("15"));

        Assert.Equal(15, EmPageTypeConverter.ConvertToType<short>(15));
        
        Assert.Equal(15, EmPageTypeConverter.ConvertToType<int>("15"));

        Assert.Equal(15, EmPageTypeConverter.ConvertToType<int>(15));
        
        Assert.Equal(15, EmPageTypeConverter.ConvertToType<long>("15"));

        Assert.Equal(15, EmPageTypeConverter.ConvertToType<long>(15));
        
        Assert.Equal(int.MaxValue, EmPageTypeConverter.ConvertToType<int>(int.MaxValue));
        
        Assert.Equal(int.MinValue, EmPageTypeConverter.ConvertToType<int>(int.MinValue));

        Assert.Equal(long.MaxValue, EmPageTypeConverter.ConvertToType<long>(long.MaxValue));
        
        Assert.Equal(long.MinValue, EmPageTypeConverter.ConvertToType<long>(long.MinValue));

        Assert.Equal(0, EmPageTypeConverter.ConvertToType<int>(long.MaxValue));

        Assert.Equal(0, EmPageTypeConverter.ConvertToType<int>(long.MinValue));

        Assert.Equal(0, EmPageTypeConverter.ConvertToType<int>("s15s"));

        Assert.Equal(0, EmPageTypeConverter.ConvertToType<int>(null));
        
        Assert.Equal(0, EmPageTypeConverter.ConvertToType<int>(string.Empty));

        Assert.Equal(15, EmPageTypeConverter.ConvertToType<int?>("15"));
        
        Assert.Equal(15, EmPageTypeConverter.ConvertToType<int?>(15));
        
        Assert.Equal(15, EmPageTypeConverter.ConvertToType<long?>("15"));
        
        Assert.Equal(15, EmPageTypeConverter.ConvertToType<long?>(15));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<short?>("s15s"));

        Assert.Null(EmPageTypeConverter.ConvertToType<short?>(null));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<short?>(string.Empty));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<int?>("s15s"));

        Assert.Null(EmPageTypeConverter.ConvertToType<int?>(null));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<int?>(string.Empty));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<long?>("s15s"));

        Assert.Null(EmPageTypeConverter.ConvertToType<long?>(null));
        
        Assert.Null(EmPageTypeConverter.ConvertToType<long?>(string.Empty));
    }
}