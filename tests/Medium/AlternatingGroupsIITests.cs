using System.Collections;
using solutions.Medium;

namespace tests.Medium;

public class AlternatingGroupsIITests
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 1, 0 }, 3, 3)]
    [InlineData(new int[] { 0,1,0,0,1,0,1}, 6, 2)]
    public void NumberOfAlternatingGroups_WhenGivenArrayColors_ReturnsCorrectResult(int[] colors, int k, int expected)
    {
        // arrange
        var solution = new AlternatingGroupsIISolution();
        // act
        var result = solution.NumberOfAlternatingGroups(colors, k);
        // assert
        Assert.Equal(expected, result);
    }
    
}