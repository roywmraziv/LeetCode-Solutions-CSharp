using LeetCodeSolutions.Solutions.LengthOfLastWord;

namespace tests.Easy;

public class LengthOfLastWordTests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    [InlineData("s ", 1)]
    public void LengthOfLastWord_WhenPassedString_ReturnsExpectedLength(string s, int length)
    {
        // arrange
        var solution = new LengthOfLastWordSolution();
        // act 
        int result = solution.LengthOfLastWord(s);
        // assert
        Assert.Equal(length, result);
    }
}