using solutions.Easy;

namespace tests.Easy;

public class MinimumStringLengthAfterRemovingSubstringsTests
{
    [Fact]
    public void MinLength_WhenStringIsAB_ReturnsZero()
    {
        // arrange
        var solution = new MinimumStringLengthAfterRemovingSubstringsSolution();
        string s = "AB";
        // act
        int result = solution.MinLength(s);
        // assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void MinLength_WhenStringIsABB_ReturnsOne()
    {
        // arrange
        var solution = new MinimumStringLengthAfterRemovingSubstringsSolution();
        string s = "ABB";
        // act
        int result = solution.MinLength(s);
        // assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void MinLength_WhenStringIsABBCD_ReturnsOne()
    {
        // arrange
        var solution = new MinimumStringLengthAfterRemovingSubstringsSolution();
        string s = "ABBCD";
        // act
        int result = solution.MinLength(s);
        // assert
        Assert.Equal(1, result);
    }
}