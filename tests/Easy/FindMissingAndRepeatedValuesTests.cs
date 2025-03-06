using System.Collections;
using solutions.Easy;

namespace tests.Easy;

public class FindMissingAndRepeatedValuesTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void FindMissingAndRepeatedValues_WhenGivenGrid_ReturnsCorrectResult(int[][] grid, int[] expected)
    {
        // arrange
        var solution = new FindMissingAndRepeatedValuesSolution();
        // act 
        var result = solution.FindMissingAndRepeatedValues(grid);
        // assert
        Assert.Equal(expected, result);
    }
}
public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { new[] { new[] { 1, 3 }, new[] { 2, 2 } }, new[] { 2, 4 } };
        yield return new object[] { new[] { new[] { 9, 1, 7 }, new[] { 8, 9, 2 }, new[] { 3, 4, 6 } }, new[] { 9, 5 } };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}