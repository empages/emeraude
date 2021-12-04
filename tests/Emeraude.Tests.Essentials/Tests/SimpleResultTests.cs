using Emeraude.Essentials.Models;
using FluentAssertions;
using Xunit;

namespace Emeraude.Tests.Essentials.Tests;

public class SimpleResultTests
{
    [Fact]
    public void SuccessfulResult_OnNewInstance_ShouldReturnSucceededTrue()
    {
        var result = SimpleResult.SuccessfulResult;
        result.Succeeded.Should().BeTrue();
    }
        
    [Fact]
    public void UnsuccessfulResult_OnNewInstance_ShouldReturnSucceededFalse()
    {
        var result = SimpleResult.UnsuccessfulResult;
        result.Succeeded.Should().BeFalse();
    }

    [InlineData(true)]
    [InlineData(false)]
    [Theory]
    public void NewInstance_ViaConstructor_ShouldReturnConstructorValue(bool value)
    {
        var result = new SimpleResult(value);
        result.Succeeded.Should().Be(value);
    }
}