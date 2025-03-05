using solutions.Medium;
namespace tests.Medium;

public class CountTotalNumberOfColoredCellsTests
{
    [Fact]
    public void ColoredCells_WhenNIsOne_ReturnsOne()
    {
        //Arrange
        var solution = new CountTotalNumberOfColoredCellsSolution();
        int n = 1;
        //Act
        long result = solution.ColoredCells(n);
        //Assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void ColoredCells_WhenAnswerIsBeyondInt32_ReturnsLong()
    {
        //Arrange
        var solution = new CountTotalNumberOfColoredCellsSolution();
        int n = 69675;
        //Act
        long result = solution.ColoredCells(n);
        //Assert
        Assert.Equal(9709071901, result);
        Assert.IsType<long>(result);
    }
    
    [Fact]
    public void ColoredCells_WhenNIsFour_ReturnsTwentyFive()
    {
        //Arrange
        var solution = new CountTotalNumberOfColoredCellsSolution();
        int n = 4;
        //Act
        long result = solution.ColoredCells(n);
        //Assert
        Assert.Equal(25, result);
    }
    
}