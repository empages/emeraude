using Emeraude.Essentials.Helpers;
using Xunit;

namespace Emeraude.Tests.Essentials.Tests;

public class StringFunctionsTests
{
    [InlineData("HelloWorld", "Hello World")]
    [InlineData("ThisIsSomeVeryLongText", "This Is Some Very Long Text")]
    [InlineData("UIComponent", "UI Component")]
    [InlineData("POWER", "POWER")]
    [InlineData("Hello World", "Hello World")]
    [InlineData("Hello_World", "Hello World")]
    [InlineData("Hello_Big Big_World", "Hello Big Big World")]
    [InlineData("Hello_Big BIGWorld", "Hello Big BIG World")]
    [InlineData("SOLIDPrinciple", "SOLID Principle")]
    [InlineData("powerIsPower", "power Is Power")]
    [InlineData("SOLID_PRINCIPLE", "SOLIDPRINCIPLE")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("     ", "")]
    [Theory]
    public void SplitWordsByCapitalLetters_EnterVariousStrings_ValidResult(string input, string expectedOutput)
    {
        string resultOutput = StringUtilities.SplitWordsByCapitalLetters(input);
        Assert.Equal(expectedOutput, resultOutput);
    }

    [InlineData("HelloWorld", "HELLO_WORLD")]
    [InlineData("ThisIsSomeVeryLongText", "THIS_IS_SOME_VERY_LONG_TEXT")]
    [InlineData("UIComponent", "UI_COMPONENT")]
    [InlineData("POWER", "POWER")]
    [InlineData("Hello World", "HELLO_WORLD")]
    [InlineData("Hello        World", "HELLO_WORLD")]
    [InlineData("Hello_World", "HELLO_WORLD")]
    [InlineData("Hello_Big Big_World", "HELLO_BIG_BIG_WORLD")]
    [InlineData("Hello_Big BIGWorld", "HELLO_BIG_BIG_WORLD")]
    [InlineData("SOLIDPrinciple", "SOLID_PRINCIPLE")]
    [InlineData("powerIsPower", "POWER_IS_POWER")]
    [InlineData("SOLID_PRINCIPLE", "SOLID_PRINCIPLE")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("     ", "")]
    [Theory]
    public void ConvertToKey_EnterVariousStrings_ValidResult(string input, string expectedOutput)
    {
        string resultOutput = StringUtilities.ConvertToKey(input);
        Assert.Equal(expectedOutput, resultOutput);
    }
        
    [InlineData("Hello     World", "Hello World")]
    [InlineData("hello     world", "hello world")]
    [InlineData("ThisIsSomeVeryLongText", "ThisIsSomeVeryLongText")]
    [InlineData("This Is Some Very Long Text", "This Is Some Very Long Text")]
    [InlineData("This Is       Some Very      Long Text", "This Is Some Very Long Text")]
    [InlineData("", "")]
    [InlineData("     ", " ")]
    [InlineData(" ", " ")]
    [InlineData(null, "")]
    [Theory]
    public void ClearMultipleIntervals_EnterVariousStrings_ValidResult(string input, string expectedOutput)
    {
        string resultOutput = StringUtilities.ClearMultipleIntervals(input);
        Assert.Equal(expectedOutput, resultOutput);
    }
}