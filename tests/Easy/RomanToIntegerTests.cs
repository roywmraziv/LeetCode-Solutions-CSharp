using LeetCodeSolutions.Solutions.RomanToInteger;

namespace tests.Easy;

public class RomanToIntegerTests
{
    [Theory]
    [InlineData("I", 1)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_WhenInputIsNumeral_ReturnsCorrectInteger(string s, int expected)
    {
        // arrange
        var solution = new RomanToIntegerSolution();
        
        // act
        int result = solution.RomanToInt(s);
        // assert
        Assert.Equal(expected, result);
    }
}