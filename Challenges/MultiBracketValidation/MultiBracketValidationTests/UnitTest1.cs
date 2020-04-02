using Xunit;
using static MultiBracketValidations.Program;
using System;

public class UnitTest1
{
    [Fact]
    public void BalancedBrackets()
    {
        string input = "{}{C-Sharp}[.NET5](())";
        Assert.True(MultiBracketValidation(input));
    }

    [Fact]
    public void NonBalancedBrackets()
    {
        string input = "{(Unit-Testing]}{2}";
        Assert.False(MultiBracketValidation(input));
    }

    [Fact]
    public void NoBracketsInString()
    {
        string input = "There is no brackets.";
        Assert.True(MultiBracketValidation(input));
    }
}
