using solutions.Medium;

namespace tests.Medium;

public class NumberOfSubstringsContainingAllThreeCharactersTests
{
    [Theory]
    [InlineData("abc", 1)]
    [InlineData("aaacb", 3)]
    [InlineData("abcabc", 10)]
    public void NumberOfSubstrings_WhenPassedString_ReturnsExpectedResult(string input, int expected)
    {
        // arrange
        var solution = new NumberOfSubstringsContainingAllThreeCharactersSolution();
        // act
        var result = solution.NumberOfSubstrings(input);
        // assert
        Assert.Equal(expected, result);
    }
}