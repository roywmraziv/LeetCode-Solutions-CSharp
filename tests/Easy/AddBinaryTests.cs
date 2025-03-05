using LeetCodeSolutions.Solutions.AddBinary;

namespace tests.Easy;

public class AddBinaryTests
{
    [Fact]
    public void AddBinary_BasicAddition_ReturnsCorrectSum()
    {
        // Arrange
        var solution = new AddBinarySolution();
        string a = "11";
        string b = "1";
        string expected = "100";

        // Act
        string result = solution.AddBinary(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}