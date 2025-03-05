namespace solutions.Medium;

public class CountTotalNumberOfColoredCellsSolution
{
    public long ColoredCells(int n) {
        return ((long)n * n) + ((long)(n - 1) * (n - 1));
    }
}