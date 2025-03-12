using solutions.Easy;

namespace tests.Easy;

public class MaximumCountOfPositiveIntegerAndNegativeIntegerTests
{
    [Theory]
    [InlineData(new int[] {-2,-1,-1,1,2,3 }, 3)]
    [InlineData(new int[] {-3,-2,-1,0,0,1,2}, 3)]
    [InlineData(new int[] {5,20,66,1314}, 4)]
    public void MaximumCount_WhenPassedArray_ReturnsExpectedResult(int[] nums, int expected)
    {
        // arrange
        var solution = new MaximumCountOfPositiveIntegerAndNegativeIntegerSolution();
        // act
        var result = solution.MaximumCount(nums);
        // assert
        Assert.Equal(expected, result);
    }
}